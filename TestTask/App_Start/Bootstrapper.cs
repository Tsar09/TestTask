using System.Web.Http;
using TestTask.Configs;

namespace TestTask.App_Start
{
    public class Bootstrapper
    {
        public static void Run()
        {
            AutofacConfig.Initialize(GlobalConfiguration.Configuration);
        }
    }
}