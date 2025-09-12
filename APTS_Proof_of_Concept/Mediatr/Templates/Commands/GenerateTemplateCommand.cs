using APTS_Proof_of_Concept.Mediatr.Templates.Responses;
using MediatR;

namespace APTS_Proof_of_Concept.Mediatr.Templates.Commands
{
    public record GenerateTemplateCommand(int TemplateId, int ProgrammeId, bool isPdf = false) : IRequest<TemplateFileResponse>;
}
