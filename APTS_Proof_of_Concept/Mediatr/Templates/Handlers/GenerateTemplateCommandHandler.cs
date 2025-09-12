using APTS_Proof_of_Concept.Data;
using APTS_Proof_of_Concept.Mediatr.Templates.Commands;
using APTS_Proof_of_Concept.Mediatr.Templates.Responses;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Text.RegularExpressions;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace APTS_Proof_of_Concept.Mediatr.Templates.Handlers
{
    public class GenerateTemplateCommandHandler : IRequestHandler<GenerateTemplateCommand, TemplateFileResponse>
    {
        private readonly string _templatesPath;
        private readonly AppDbContext _context;

        public GenerateTemplateCommandHandler(IWebHostEnvironment env, AppDbContext context)
        {
            _templatesPath = Path.Combine(env.WebRootPath, "templates");
            _context = context;
        }

        public async Task<TemplateFileResponse> Handle(
            GenerateTemplateCommand request,
            CancellationToken cancellationToken)
        {
            try
            {
                var templateEntity = await _context.Templates.SingleAsync(t => t.TPk == request.TemplateId, cancellationToken);

                if (!File.Exists(templateEntity.TPath))
                    templateEntity.TPath = Path.Combine(_templatesPath, templateEntity.TDescription + ".docx");

                if (!File.Exists(templateEntity.TPath))
                    throw new FileNotFoundException($"Template {templateEntity.TName} not found.");

                // Copy template to temp file
                string tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString("N") + ".docx");
                File.Copy(templateEntity.TPath, tempPath, true);

                byte[] fileBytes;

                try
                {
                    using (WordprocessingDocument doc = WordprocessingDocument.Open(tempPath, true))
                    {
                        var mainPart = doc.MainDocumentPart
                            ?? throw new InvalidOperationException("MainDocumentPart missing.");

                        // Collect placeholders from body, headers, and footers
                        var allPlaceholders = new HashSet<string>(StringComparer.OrdinalIgnoreCase);                                                 

                        if (mainPart.Document?.Body != null)
                            CollectPlaceholders(mainPart.Document.Body, allPlaceholders);

                        // This should not be neccesary as headers/footers are accessible via MainDocumentPart
                        //foreach (var header in mainPart.HeaderParts)
                        //    if (header.Header != null)
                        //        CollectPlaceholders(header.Header, allPlaceholders);

                        //foreach (var footer in mainPart.FooterParts)
                        //    if (footer.Footer != null)
                        //        CollectPlaceholders(footer.Footer, allPlaceholders);

                        // TODO: Next step — call stored procedure with programmeId and placeholders
                        Console.WriteLine($"Found placeholders in {templateEntity.TName}: {string.Join(", ", allPlaceholders)}");

                        doc.MainDocumentPart.Document.Save();
                    }

                    // Read into memory
                    fileBytes = await File.ReadAllBytesAsync(tempPath, cancellationToken);
                }
                finally
                {
                    try { File.Delete(tempPath); } catch { /* ignore cleanup issues */ }
                }

                // RETURN
                return new TemplateFileResponse
                {
                    FileBytes = fileBytes,
                    FileName = $"{templateEntity.TName}_{request.ProgrammeId}.docx",
                    ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                };
            }
            catch (Exception exception)
            {
                // Log the exception
                Log.Error($"An error occurred: {exception.Message}");
                throw; // Re-throw the exception after logging it
            }
        }

        private void CollectPlaceholders(OpenXmlElement container, HashSet<string> placeholders)
        {
            var regex = new Regex(@"#HEDA_[^#]+#", RegexOptions.Compiled);

            foreach (var text in container.Descendants<Text>())
            {
                if (!string.IsNullOrEmpty(text.Text))
                {
                    var matches = regex.Matches(text.Text);
                    foreach (Match match in matches)
                        placeholders.Add(match.Value);
                }
            }
        }
    }
}
