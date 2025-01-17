using ApiPdfGenerator.Responses;
using Domain.Entities;
using Domain.Handlers.Templates;
using Microsoft.AspNetCore.Mvc;

namespace ApiPdfGenerator.Controllers
{
    [Route("api/templates")]
    [ApiController]
    public class TemplatesController : ControllerBase
    {
        /// <summary>
        /// Retrieves a list of available contract templates
        /// </summary>
        [HttpGet()]
        [ProducesResponseType(typeof(ListTemplatesResp), StatusCodes.Status200OK)]
        public async Task<ActionResult> ListTemplatesAsync(
            [FromServices] IListTemplatesHandler handler)
        {
            IEnumerable<Template> templates = await handler.ListTemplatesAsync();
            
            ListTemplatesResp response = new(templates);

            return Ok(response);
        }

        /// <summary>
        /// Fill the selected template with the contract info and return a PDF in base64.
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="id">Id of template to be used</param>
        /// <returns></returns>
        [HttpPost("{id}/generate-contract")]
        public async Task<ActionResult> GenerateContract(
            [FromServices] IGenerateContractHandler handler, int id)
        {
            var result = await handler.GenerateContractAsync();

            return Ok(result);
        }
    }
}
