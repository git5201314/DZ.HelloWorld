using System.Web.Http;

namespace DZ.HelloWorld.WebApp.Controllers
{
    public class TestController : ApiController
    {
        public string Index()
        {
            return "Hello World!";
        }

        public string SayHello(string name)
        {
            return $"Hello {name}";
        }
    }
}
