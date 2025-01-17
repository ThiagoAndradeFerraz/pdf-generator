using Domain.Entities;

namespace Infra.Queries
{
    public static class ContractQueries
    {
        public const string ListTemplatesQuery =
            $"""
            SELECT
                template_id AS {nameof(Template.Id)},
                description AS {nameof(Template.Description)}
            FROM 
                pdf_generator.contract_templates
            """;
    }
}
