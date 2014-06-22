using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using web_api_i0.App_Start;

namespace web_api_i0
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.RegisterRoutes(GlobalConfiguration.Configuration.Routes);
            GlobalConfiguration.Configuration.Formatters.Add(new JsonMediaTypeFormatter());
//            GlobalConfiguration.Configuration.Formatters.Add(new TextPlai/nFormatter());
        }
    }
}