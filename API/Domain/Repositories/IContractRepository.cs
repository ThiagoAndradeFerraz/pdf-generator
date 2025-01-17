using Domain.Entities;

namespace Domain.Repositories
{
    public interface IContractRepository
    {
        public Task<IEnumerable<Template>> ListTemplatesAsync();
        public Task<string?> GetTemplatePath(int id);
    }
}
