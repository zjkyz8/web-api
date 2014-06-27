using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using SimpleInjector;

namespace web_api_i0
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : HttpApplication
    {
        public static Container Container { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            HttpConfiguration httpConfiguration = GlobalConfiguration.Configuration;
            WebApiConfig.RegisterRoutes(httpConfiguration.Routes);
            WebApiConfig.RegisterFormatters(httpConfiguration.Formatters);
            Container = WebApiConfig.RegisterContainer();
        }
    }
}