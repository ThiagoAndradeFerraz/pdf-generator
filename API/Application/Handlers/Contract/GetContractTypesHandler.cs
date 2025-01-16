using Domain.Entities;
using Domain.Handlers.Contract;

namespace Application.Handlers.Contract
{
    public class GetContractTypesHandler : IListTemplateOptions
    {
        public async Task<IEnumerable<Template>> ListTemplates()
        {
            // TODO: implement real query, this one is just a test
            return new List<Template>() { new Template() { Id = 1, Description = "aasadf"} };
        }
    }
}
