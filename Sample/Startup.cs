using Owin;
using System.Web.Http;

namespace Sample
{
    public class Startup
    {                
        public void Configuration(IAppBuilder appBuilder)
        {
            appBuilder.Use((context, next) =>
            {
                context.Response.Headers.Remove("Server");
                return next.Invoke();
            });
            
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            //// Web API routes
            config.EnableCors();
            config.MapHttpAttributeRoutes();
            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            appBuilder.UseWebApi(config);
        }
    }
}