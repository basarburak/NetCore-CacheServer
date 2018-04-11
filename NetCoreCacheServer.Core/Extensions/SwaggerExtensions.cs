using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace NetCoreCacheServer.Core.Extensions
{
    public static class SwaggerExtensions
    {
        public static void AddSwaggerCore(this IServiceCollection services, string title, string version)
        {
            services.AddSwaggerGen(c =>
               {
                   c.SwaggerDoc(version, new Info { Title = title, Version = version });
               });
        }
        public static void UseSwaggerCore(this IApplicationBuilder app, string apiName)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", apiName);
            });
        }
    }
}