using System;
using System.Net;
using System.Net.Http;
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
            dynamic readAsAsync = response.Content.ReadAsAsync<object>().Result;

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual("hello world", readAsAsync.message.ToString());
        }
    }
}


