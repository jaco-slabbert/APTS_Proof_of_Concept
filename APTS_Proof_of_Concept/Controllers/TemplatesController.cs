using APTS_Proof_of_Concept.Mediatr.Templates.Queries;
using APTS_Proof_of_Concept.Mediatr.Templates.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace APTS_Proof_of_Concept.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplatesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TemplatesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<TemplateDto>>> GetAvailableTemplates()
        {
            try 
            {
                var result = await _mediator.Send(new GetAvailableTemplatesQuery()); // Mediatr query being called here
                return Ok(result);
            }
            catch (Exception ex)
            {
                // For simplicity, we're just returning a 500 status code
                return StatusCode(500, $"Internal server error");
            }
        }
    }
}
