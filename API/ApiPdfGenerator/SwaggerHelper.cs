using Microsoft.OpenApi.Models;
using System.Reflection;

namespace ApiPdfGenerator
{
    public static class SwaggerHelper
    {
        public static void ConfigureSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(
                    "v1",
                    new OpenApiInfo()
                    {
                        Version = "v1",
                        Title = "api-pdf-generator",
                        Description = "API dedicated for contract generation in PDF format."
                    });

                var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
            });
        }
    }
}
