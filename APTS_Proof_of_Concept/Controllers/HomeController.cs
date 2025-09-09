using APTS_Proof_of_Concept.Models;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO.Compression;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;
using V = DocumentFormat.OpenXml.Vml;
using VOffice = DocumentFormat.OpenXml.Vml.Office;

namespace APTS_Proof_of_Concept.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _env;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult DownloadTemplates()
        {
            // Path to your templates folder
            var templatesFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "templates");

            if (!Directory.Exists(templatesFolder))
            {
                return NotFound("Templates folder not found.");
            }

            // Get all .docx files
            var files = Directory.GetFiles(templatesFolder, "*.docx");

            if (files.Length == 0)
            {
                return NotFound("No template files found.");
            }

            // Create the zip in memory
            using (var memoryStream = new MemoryStream())
            {
                using (var zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    foreach (var filePath in files)
                    {
                        var fileBytes = System.IO.File.ReadAllBytes(filePath);
                        var fileName = Path.GetFileName(filePath);
                        var entry = zipArchive.CreateEntry(fileName, CompressionLevel.Fastest);

                        using (var entryStream = entry.Open())
                        {
                            entryStream.Write(fileBytes, 0, fileBytes.Length);
                        }
                    }
                }

                memoryStream.Position = 0; // Reset stream position
                return File(memoryStream.ToArray(), "application/zip", "templates.zip");
            }
        }

        [HttpGet]
        public IActionResult GenerateWithEmbed()
        {
            // Paths to local files
            string templatePath = Path.Combine(_env.WebRootPath, "templates", "Template.docx");
            string embed1Path = Path.Combine(_env.WebRootPath, "templates", "Embed1.docx");
            string embed2Path = Path.Combine(_env.WebRootPath, "templates", "Embed2.docx");

            if (!System.IO.File.Exists(templatePath))
                return NotFound("Template not found.");

            // the mapping for document placeholders (to file paths)
            var docPlaceholders = new Dictionary<string, string>(StringComparer.Ordinal)
            {
                ["<<Doc1>>"] = embed1Path,
                ["<<Doc2>>"] = embed2Path
            };

            // the mapping for text placeholders
            var textPlaceholders = new Dictionary<string, string>(StringComparer.Ordinal)
            {
                ["<<Data1>>"] = "Some data from the DB",
                ["<<X1>>"] = "X marks the spot",
                ["<<X2>>"] = "X",
                ["<<O1>>"] = "O"
            };

            // Recursively process the template and get a MemoryStream of the processed file
            var processedStream = ProcessDocumentRecursive(templatePath, textPlaceholders, docPlaceholders, new HashSet<string>(StringComparer.OrdinalIgnoreCase));

            // Return file
            processedStream.Position = 0;
            return File(processedStream.ToArray(),
                        "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                        "Generated.docx");
        }

        /// <summary>
        /// Recursively processes a document file: applies text replacements and embeds recursively-processed documents.
        /// Returns a MemoryStream containing the processed .docx bytes.
        /// </summary>
        private MemoryStream ProcessDocumentRecursive(
            string sourcePath,
            Dictionary<string, string> textReplacements,
            Dictionary<string, string> docReplacements,
            HashSet<string> visitedStack)
        {
            // normalize path and detect cycles
            string fullPath = Path.GetFullPath(sourcePath);
            if (visitedStack.Contains(fullPath))
                throw new InvalidOperationException($"Circular embedding detected for '{fullPath}'.");

            visitedStack.Add(fullPath);

            // Work on a temp copy so we can open and save safely.
            string tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N") + ".docx");
            System.IO.File.Copy(fullPath, tempPath, true);

            try
            {
                using (WordprocessingDocument doc = WordprocessingDocument.Open(tempPath, true))
                {
                    var mainPart = doc.MainDocumentPart ?? throw new InvalidOperationException("MainDocumentPart missing.");
                    // Add icon image part from local file instead of dummy PNG
                    string iconPath = Path.Combine(_env.WebRootPath, "images", "docx_icon.png");
                    if (!System.IO.File.Exists(iconPath))
                        throw new FileNotFoundException("Missing icon file", iconPath);

                    var imagePart = mainPart.AddImagePart(ImagePartType.Png);
                    using (var fs = new FileStream(iconPath, FileMode.Open, FileAccess.Read))
                        imagePart.FeedData(fs);

                    string imageRelId = mainPart.GetIdOfPart(imagePart);

                    // Prepare placeholder list (order by length descending to match longer patterns first)
                    var placeholders = textReplacements.Keys
                                        .Concat(docReplacements.Keys)
                                        .Distinct()
                                        .OrderByDescending(k => k.Length)
                                        .ToList();

                    // Process main body
                    if (mainPart.Document?.Body != null)
                        ProcessContainerForPlaceholders(mainPart.Document.Body, mainPart, textReplacements, docReplacements, placeholders, imageRelId, visitedStack);

                    // Process headers
                    foreach (var header in mainPart.HeaderParts)
                    {
                        if (header.Header != null)
                            ProcessContainerForPlaceholders(header.Header, mainPart, textReplacements, docReplacements, placeholders, imageRelId, visitedStack);
                    }

                    // Process footers
                    foreach (var footer in mainPart.FooterParts)
                    {
                        if (footer.Footer != null)
                            ProcessContainerForPlaceholders(footer.Footer, mainPart, textReplacements, docReplacements, placeholders, imageRelId, visitedStack);
                    }

                    mainPart.Document.Save();
                }

                // Read back into memory and return
                var outBytes = System.IO.File.ReadAllBytes(tempPath);
                return new MemoryStream(outBytes);
            }
            finally
            {
                visitedStack.Remove(fullPath);
                try { System.IO.File.Delete(tempPath); } catch { /* ignore cleanup failures */ }
            }
        }

        /// <summary>
        /// Scans a container (Body, Header, Footer) paragraph-by-paragraph and replaces placeholders.
        /// </summary>
        private void ProcessContainerForPlaceholders(
            OpenXmlElement container,
            MainDocumentPart mainPart,
            Dictionary<string, string> textReplacements,
            Dictionary<string, string> docReplacements,
            List<string> placeholders,
            string imageRelId,
            HashSet<string> visitedStack)
        {
            // Iterate paragraphs - use ToList() because we mutate the document while walking.
            var paragraphs = container.Descendants<Paragraph>().ToList();

            foreach (var paragraph in paragraphs)
            {
                // Keep searching this paragraph until there are no placeholders left
                bool foundAny;
                do
                {
                    foundAny = false;

                    // collect text nodes in order
                    var textNodes = paragraph.Descendants<Text>().Where(t => t.Text != null).ToList();
                    if (!textNodes.Any()) break;

                    // build cumulative offsets for quick mapping
                    var cumOffsets = new List<int>(textNodes.Count);
                    int running = 0;
                    foreach (var t in textNodes)
                    {
                        cumOffsets.Add(running);
                        running += t.Text.Length;
                    }
                    var allText = string.Concat(textNodes.Select(t => t.Text));

                    // search placeholders
                    foreach (var ph in placeholders)
                    {
                        int idx = allText.IndexOf(ph, StringComparison.Ordinal);
                        if (idx < 0) continue;

                        foundAny = true;

                        // compute start and end node index/offset
                        (int startNodeIndex, int startOffsetInNode) = GetNodeIndexAndOffset(textNodes, cumOffsets, idx);
                        (int endNodeIndex, int endOffsetInNodeExclusive) = GetNodeIndexAndOffset(textNodes, cumOffsets, idx + ph.Length);

                        if (textReplacements.ContainsKey(ph))
                        {
                            // simple text replacement
                            string replacementText = textReplacements[ph];
                            ReplaceRangeWithText(paragraph, textNodes, startNodeIndex, startOffsetInNode, endNodeIndex, endOffsetInNodeExclusive, replacementText);
                        }
                        else if (docReplacements.ContainsKey(ph))
                        {
                            // document embedding: first recursively process the embedded doc
                            string embedSourcePath = docReplacements[ph];
                            var embeddedProcessedStream = ProcessDocumentRecursive(embedSourcePath, textReplacements, docReplacements, visitedStack);
                            embeddedProcessedStream.Position = 0;

                            // add as EmbeddedPackagePart to the current document
                            var embeddedPart = mainPart.AddEmbeddedPackagePart("application/vnd.openxmlformats-officedocument.wordprocessingml.document");
                            embeddedPart.FeedData(embeddedProcessedStream);
                            string embeddedRelId = mainPart.GetIdOfPart(embeddedPart);

                            // replace placeholder range with an embedded icon run
                            ReplaceRangeWithEmbedded(paragraph, textNodes, startNodeIndex, startOffsetInNode, endNodeIndex, endOffsetInNodeExclusive, mainPart, embeddedRelId, imageRelId);
                        }

                        // after handling this placeholder in the paragraph, break to recompute the text nodes and continue
                        break;
                    }
                } while (foundAny);
            }
        }

        /// <summary>
        /// Map an absolute character position to a (text node index, offset in that node).
        /// </summary>
        private (int nodeIndex, int offsetInNode) GetNodeIndexAndOffset(List<Text> textNodes, List<int> cumOffsets, int position)
        {
            for (int i = 0; i < textNodes.Count; i++)
            {
                int nodeStart = cumOffsets[i];
                int nodeLen = textNodes[i].Text.Length;
                if (position >= nodeStart && position <= nodeStart + nodeLen) // position may be at end (exclusive)
                {
                    int offset = Math.Max(0, position - nodeStart);
                    if (offset > nodeLen) offset = nodeLen;
                    return (i, offset);
                }
            }
            // fallback to last node
            return (textNodes.Count - 1, textNodes.Last().Text.Length);
        }

        /// <summary>
        /// Replace the range spanning from (startNodeIndex,startOffset) up to (endNodeIndex,endOffsetExclusive) with plain text.
        /// </summary>
        private void ReplaceRangeWithText(Paragraph paragraph,
                                          List<Text> textNodes,
                                          int startNodeIndex, int startOffset,
                                          int endNodeIndex, int endOffsetExclusive,
                                          string replacementText)
        {
            var startText = textNodes[startNodeIndex];
            var endText = textNodes[endNodeIndex];

            var startRun = startText.Ancestors<Run>().FirstOrDefault();
            var endRun = endText.Ancestors<Run>().FirstOrDefault();

            string startOrig = startText.Text;
            string endOrig = endText.Text;

            string prefix = startOrig.Substring(0, Math.Min(startOffset, startOrig.Length));
            string suffix = endOrig.Substring(Math.Min(endOffsetExclusive, endOrig.Length));

            // update boundary text nodes
            startText.Text = prefix;
            endText.Text = suffix;

            // remove intermediate runs (unique)
            if (startRun != null && endRun != null && startRun != endRun)
            {
                // collect runs between them
                OpenXmlElement cur = startRun.NextSibling();
                while (cur != null && cur != endRun)
                {
                    var next = cur.NextSibling();
                    cur.Remove();
                    cur = next;
                }
            }

            // insert replacement run after startRun
            var replacementRun = new Run(new Text(replacementText) { Space = SpaceProcessingModeValues.Preserve });

            if (startRun != null)
            {
                startRun.Parent.InsertAfter(replacementRun, startRun);
            }
            else
            {
                // fallback: append to paragraph
                paragraph.AppendChild(replacementRun);
            }

            // if there is a suffix and startRun == endRun scenario already handled since we set endText.Text = suffix
        }

        /// <summary>
        /// Replace the (possibly multi-node) placeholder range with an embedded icon run.
        /// </summary>
        private void ReplaceRangeWithEmbedded(Paragraph paragraph,
                                              List<Text> textNodes,
                                              int startNodeIndex, int startOffset,
                                              int endNodeIndex, int endOffsetExclusive,
                                              MainDocumentPart mainPart,
                                              string embeddedRelId,
                                              string imageRelId)
        {
            var startText = textNodes[startNodeIndex];
            var endText = textNodes[endNodeIndex];

            var startRun = startText.Ancestors<Run>().FirstOrDefault();
            var endRun = endText.Ancestors<Run>().FirstOrDefault();

            string startOrig = startText.Text;
            string endOrig = endText.Text;

            string prefix = startOrig.Substring(0, Math.Min(startOffset, startOrig.Length));
            string suffix = endOrig.Substring(Math.Min(endOffsetExclusive, endOrig.Length));

            // update boundary text nodes
            startText.Text = prefix;
            endText.Text = suffix;

            // remove intermediate runs (unique)
            if (startRun != null && endRun != null && startRun != endRun)
            {
                OpenXmlElement cur = startRun.NextSibling();
                while (cur != null && cur != endRun)
                {
                    var next = cur.NextSibling();
                    cur.Remove();
                    cur = next;
                }
            }

            // Insert embedded icon run after startRun (or append if no run)
            if (startRun != null)
            {
                InsertEmbeddedIconRun(startRun.Parent, mainPart, embeddedRelId, imageRelId, after: startRun);
            }
            else
            {
                // fallback: append a new paragraph then insert
                var p = paragraph;
                InsertEmbeddedIconRun(p, mainPart, embeddedRelId, imageRelId);
            }
        }

        /// <summary>
        /// Your existing helper - inserts the VML shape + OLE object run that points to embeddedRelId.
        /// (Kept as you had it working previously)
        /// </summary>
        private void InsertEmbeddedIconRun(OpenXmlElement parentParagraphOrContainer,
                                   MainDocumentPart mainPart,
                                   string embeddedRelId,
                                   string imageRelId,
                                   Run after = null)
        {
            string shapeId = "_x0000_s" + new Random().Next(1000, 9999);
            string objectId = "_" + Guid.NewGuid().ToString("N");

            var vShape = new V.Shape(
                new V.Path() { }
            )
            {
                Id = shapeId,
                Style = "width:32pt;height:32pt", // adjust to your PNG size
                Type = "#_x0000_t75"
            };

            var imageData = new V.ImageData()
            {
                Title = "Embedded document",
                RelationshipId = imageRelId
            };
            vShape.Append(imageData);

            var oleObject = new VOffice.OleObject()
            {
                Id = embeddedRelId,
                ProgId = "Word.Document.12",
                ObjectId = objectId,
                ShapeId = shapeId,
                DrawAspect = VOffice.OleDrawAspectValues.Icon
            };
            vShape.Append(oleObject);

            var embeddedObject = new EmbeddedObject();
            embeddedObject.AppendChild(vShape);

            var embedRun = new Run(embeddedObject);

            if (after != null && after.Parent != null)
                after.Parent.InsertAfter(embedRun, after);
            else
                parentParagraphOrContainer.AppendChild(embedRun);
        }
    }
}
