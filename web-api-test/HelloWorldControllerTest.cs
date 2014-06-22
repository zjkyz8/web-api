using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using NUnit.Framework;

namespace web_api_test
{

    public class HelloWorldControllerTest : ApiTestBase
    {
        [Test]
        public void should_return_hello_world()
        {
            var httpClient = new HttpClient() {BaseAddress = new Uri(BaseUrl)};
            var response = httpClient.GetAsync("helloworld").Result;
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}


