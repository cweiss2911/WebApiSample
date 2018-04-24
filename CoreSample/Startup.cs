using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CoreSample
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddCors(options =>
               options.AddPolicy("AllowSpecificOrigins",
               builder =>
               {
                   builder.WithOrigins("http://localhost:4200", "http://192.168.99.100", "http://192.168.2.101");
               }));

        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
             loggerFactory.AddConsole(LogLevel.Information);
            app.UseMvc();
            app.UseCors("AllowSpecificOrigins");
        }

    }
}