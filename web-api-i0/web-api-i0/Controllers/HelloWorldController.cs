using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web_api_i0.Controllers
{
    
    public class HelloWorldController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage HelloWorld()
        {
            var response = Request.CreateResponse(HttpStatusCode.OK, new HelloWorldResponse());
          
            return response;
        }
    }

    public class HelloWorldResponse
    {
        public string Message
        {
            get { return "hello world"; }
        }
    }
}
