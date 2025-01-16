using Domain.Entities;

namespace ApiPdfGenerator.Responses
{
    public class TemplateResp
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;

        public TemplateResp(Template entity)
        {
            Id = entity.Id;
            Description = entity.Description;
        }
    }
}
