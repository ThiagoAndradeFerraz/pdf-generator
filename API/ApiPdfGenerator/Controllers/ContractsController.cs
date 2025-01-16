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
        /// Retrieves a list of available types of contracts.
        /// </summary>
        [HttpGet("types")]
        [ProducesResponseType(typeof(IEnumerable<ContractType>), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetTypesAsync(
            [FromServices] IGetContractTypesHandler handler)
        {
            var contractTypes = await handler.GetContractTypesAsync();
            return Ok(contractTypes);
        }
    }
}
