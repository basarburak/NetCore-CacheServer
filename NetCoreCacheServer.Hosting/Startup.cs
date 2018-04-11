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
using NetCoreCacheServer.Core.Configration;
using NetCoreStack.Proxy;
using NetCoreCacheServer.Core.Extensions;

namespace NetCoreCacheServer.Hosting
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddNetCoreProxy(Configuration, options =>
             {
                 options.Register<ICacheApi>();
             });

            services.AddSwaggerCore(ApiConfigration.HostingApiName, ApiConfigration.HostingApiVersion);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwaggerCore(ApiConfigration.HostingApiName);
        }
    }
}
