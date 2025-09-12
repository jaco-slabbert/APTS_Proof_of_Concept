using APTS_Proof_of_Concept.Mediatr.Templates.Responses;
using MediatR;

namespace APTS_Proof_of_Concept.Mediatr.Templates.Queries
{
    public record GetAvailableTemplatesQuery() : IRequest<List<TemplateDto>>;
}
