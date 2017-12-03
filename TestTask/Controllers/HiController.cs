using System.Web.Http;
using TestTask.Services.Interfaces;

namespace TestTask.Controllers
{
    public class HiController : ApiController
    {
        private readonly IGreeterService greeterService;

        public HiController(IGreeterService greeterService)
        {
            this.greeterService = greeterService;
        }

        public string Get()
        {
            return greeterService.SayHello();
        }
    }
}
