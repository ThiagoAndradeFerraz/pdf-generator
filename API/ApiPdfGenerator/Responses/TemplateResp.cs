using Domain.Entities;

namespace ApiPdfGenerator.Responses
{
    public class TemplateResp(Template entity)
    {
        public int Id { get; } = entity.Id;
        public string Description { get; set; } = entity.Description;
    }
}
