using Domain.Entities;

namespace Domain.Repositories
{
    public interface IContractRepository
    {
        public Task<IEnumerable<Template>> ListTemplatesAsync();
    }
}
