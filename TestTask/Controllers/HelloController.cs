using System.Web.Http;
using TestTask.Services.Interfaces;

namespace TestTask.Controllers
{
    public class HelloController : ApiController
    {
        private readonly IGreeterService greeterService;

        public HelloController(IGreeterService greeterService)
        {
            this.greeterService = greeterService;
        }

        public string Get()
        {
            return greeterService.SayHello();
        }
    }
}
