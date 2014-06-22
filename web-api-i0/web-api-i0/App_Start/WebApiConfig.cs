using System.Web.Http;
using System.Web.Routing;

namespace web_api_i0.App_Start
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
    }
}