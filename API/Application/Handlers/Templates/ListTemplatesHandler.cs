using Domain.Entities;
using Domain.Handlers.Templates;
using Domain.Repositories;

namespace Application.Handlers.Templates
{
    public class ListTemplatesHandler(
        IContractRepository repository) : IListTemplatesHandler
    {
        public readonly IContractRepository _repository = repository;

        public async Task<IEnumerable<Template>> ListTemplatesAsync()
        {
            IEnumerable<Template> templates = await _repository.ListTemplatesAsync();
            return templates;
        }
    }
}
