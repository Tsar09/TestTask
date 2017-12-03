using TestTask.Services.Interfaces;

namespace TestTask.Services
{
    public class HelloService : IGreeterService
    {
        public string SayHello()
        {
            return "Hi everyone!";
        }
    }
}