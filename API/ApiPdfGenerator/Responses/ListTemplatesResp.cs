using Domain.Entities;

namespace ApiPdfGenerator.Responses
{
    public class ListTemplatesResp
    {
        public List<TemplateResp> AvailableTemplates { get; set; } = [];
    
        public ListTemplatesResp(IEnumerable<Template> templates)
        {
            foreach(Template template in templates)
            {
                AvailableTemplates.Add(new TemplateResp(template));
            }
        }
    }
}
