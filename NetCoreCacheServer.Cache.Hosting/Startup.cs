using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NetCoreCacheServer.Cache.Contract.Contract;
using NetCoreCacheServer.Core;
using NetCoreCacheServer.Core.Configration;
using NetCoreCacheServer.Core.Extensions;
using NetCoreStack.Proxy;

namespace NetCoreCacheServer.Cache.Hosting
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddMicrosoftCache();

            // services.AddRedisCache(RedisConfigration.RedisServer, RedisConfigration.InstanceName);

            services.StartBrowserSwaggerUI(DevelopmentConfigration.CacheApiUrl, DevelopmentConfigration.Browser.chrome);

            services.AddSwaggerCore(ApiConfigration.CacheApiName, ApiConfigration.CacheApiVersion);
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwaggerCore(ApiConfigration.CacheApiName);
        }
    }
}
