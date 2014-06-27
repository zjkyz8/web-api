using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SimpleInjector;

namespace web_api_i0
{
    public class WebApiConfig
    {
        public static void RegisterRoutes(HttpRouteCollection routes)
        {
            routes.MapHttpRoute(
                name: "helloWorld",
                routeTemplate: "helloworld",
                defaults: new { controller = "HelloWorld", method = "HelloWorld" });   
             
        }

        public static void RegisterFormatters(MediaTypeFormatterCollection formatters)
        {
            formatters.JsonFormatter.SerializerSettings.Formatting = Formatting.Indented;
            formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        public static Container RegisterContainer()
        {
            var container = new Container();

            return container;
        }
    }
}