using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace web_api_i0.Controllers
{
    
    public class HelloWorldController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage HelloWorld()
        {
            string helloWorld = "hello world";
            return Request.CreateResponse(HttpStatusCode.OK, helloWorld);
        }
    }
}
