using Domain.Entities;
using Domain.Handlers.Contract;
using Domain.Repositories;

namespace Application.Handlers.Contract
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
