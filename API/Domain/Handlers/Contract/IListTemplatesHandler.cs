using Domain.Entities;

namespace Domain.Handlers.Contract
{
    public interface IListTemplatesHandler
    {
        public Task<IEnumerable<Template>> ListTemplatesAsync();
    }
}
