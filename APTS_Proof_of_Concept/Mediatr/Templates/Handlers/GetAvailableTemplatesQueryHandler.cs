using APTS_Proof_of_Concept.Data;
using APTS_Proof_of_Concept.Mediatr.Templates.Queries;
using APTS_Proof_of_Concept.Mediatr.Templates.Responses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace APTS_Proof_of_Concept.Mediatr.Templates.Handlers
{
    public class GetAvailableTemplatesQueryHandler : IRequestHandler<GetAvailableTemplatesQuery, List<TemplateDto>>
    {
        private readonly AppDbContext _context;

        public GetAvailableTemplatesQueryHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TemplateDto>> Handle(
            GetAvailableTemplatesQuery request,
            CancellationToken cancellationToken)
        {
            try
            {
                var dbTemplates = await _context.Templates
                    .Where(t => t.TEnabled == true)
                    .Select(t => new TemplateDto
                    {
                        Id = t.TPk,
                        Name = t.TName,
                        Description = t.TDescription
                    })
                    .ToListAsync();

                return dbTemplates;
            }
            catch (Exception exception)
            {
                // Log the exception
                Log.Error($"An error occurred: {exception.Message}");
                throw; // Re-throw the exception after logging it
            }
        }
    }
}
