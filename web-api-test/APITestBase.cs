using System.Web.Http.SelfHost;
using NUnit.Framework;
using web_api_i0;

namespace web_api_test
{
    public class ApiTestBase
    {
        protected const string BaseUrl = "http://localhost:9001";
        private HttpSelfHostServer _server;

        [SetUp]
        public void SetUp()
        {
            var config = new HttpSelfHostConfiguration(BaseUrl);
            WebApiConfig.RegisterRoutes(config.Routes);
            WebApiConfig.RegisterFormatters(config.Formatters);
            _server = new HttpSelfHostServer(config);
            _server.OpenAsync().Wait();
        }

        [TearDown]
        public void TearDown()
        {
            _server.CloseAsync();
        }
    }
}