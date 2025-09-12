namespace APTS_Proof_of_Concept.Mediatr.Templates.Responses
{
    public class TemplateFileResponse
    {
        public byte[] FileBytes { get; set; } = Array.Empty<byte>();
        public string FileName { get; set; } = string.Empty;
        public string ContentType { get; set; } = "application/octet-stream";
    }
}
