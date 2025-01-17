using ApiPdfGenerator.Responses;
using Domain.Entities;
using Domain.Handlers.Contract;
using Microsoft.AspNetCore.Mvc;

namespace ApiPdfGenerator.Controllers
{
    [Route("api/contracts")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        /// <summary>
        /// Retrieves a list of available contract templates
        /// </summary>
        [HttpGet("templates")]
        [ProducesResponseType(typeof(ListTemplatesResp), StatusCodes.Status200OK)]
        public async Task<ActionResult> ListTemplatesAsync(
            [FromServices] IListTemplatesHandler handler)
        {
            IEnumerable<Template> templates = await handler.ListTemplatesAsync();
            
            ListTemplatesResp response = new(templates);
            
            return Ok(response);
        }
    }
}
