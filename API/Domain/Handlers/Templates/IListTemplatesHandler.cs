using Domain.Entities;

namespace Domain.Handlers.Templates
{
    public interface IListTemplatesHandler
    {
        public Task<IEnumerable<Template>> ListTemplatesAsync();
    }
}
