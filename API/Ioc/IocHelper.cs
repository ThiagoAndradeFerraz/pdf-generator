using Application.Handlers.Templates;
using Domain.Handlers.Templates;
using Domain.Repositories;
using Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Ioc
{
    public static class IocHelper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IContractRepository, ContractRepository>();

            services.AddScoped<IListTemplatesHandler, ListTemplatesHandler>();
            services.AddScoped<IGenerateContractHandler, GenerateContractHandler>();
        }
    }
}
