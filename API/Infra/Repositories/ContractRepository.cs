using Dapper;
using Domain.Entities;
using Domain.Repositories;
using Infra.Queries;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace Infra.Repositories
{
    public class ContractRepository(IConfiguration configuration) : IContractRepository
    {
        private readonly IConfiguration _configuration = configuration;

        public async Task<IEnumerable<Template>> ListTemplatesAsync()
        {
            using var connection = CreateConnection();

            IEnumerable<Template> templates = 
                await connection.QueryAsync<Template>(ContractQueries.ListTemplatesQuery);

            return templates;
        }

        public async Task<string?> GetTemplatePath(int id)
        {
            using var connection = CreateConnection();

            string? path = await connection.ExecuteScalarAsync<string>(
                ContractQueries.GetTemplatePathQuery, new { TemplateId = id });

            return path;
        }

        private MySqlConnection CreateConnection()
        {
            string connString =
                _configuration["ConnectionStrings:PdfGenerator"] ?? throw new ArgumentException(
                    "Connection string is not set in AppSettings file");

            return new MySqlConnection(connString);
        }
    }
}
