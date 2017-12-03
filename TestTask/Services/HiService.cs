using TestTask.Services.Interfaces;

namespace TestTask.Services
{
    public class HiService : IGreeterService
    {
        public string SayHello()
        {
            return "Hi there!";
        }
    }
}