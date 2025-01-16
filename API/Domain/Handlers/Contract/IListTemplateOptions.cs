using Domain.Entities;

namespace Domain.Handlers.Contract
{
    public interface IListTemplateOptions
    {
        public Task<IEnumerable<Template>> ListTemplates();
    }
}
