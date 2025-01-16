using Application.Handlers.Contract;
using Domain.Handlers.Contract;
using Microsoft.Extensions.DependencyInjection;

namespace Ioc
{
    public static class IocHelper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IListTemplateOptions, GetContractTypesHandler>();
        }
    }
}
