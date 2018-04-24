using Owin;
using System.Web.Http;
using System.Web.Http.Cors;

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

            
            HttpConfiguration config = new HttpConfiguration();
            var cors = new EnableCorsAttribute("http://localhost:4200,http://192.168.99.100", "*", "*");
            config.EnableCors(cors);

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