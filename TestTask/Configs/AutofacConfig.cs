using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;
using TestTask.Controllers;
using TestTask.Services;
using TestTask.Services.Interfaces;

namespace TestTask.Configs
{
    public class AutofacConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<HelloService>()
                .As<IGreeterService>()
                .AsSelf();

            builder.RegisterType<HiService>()
                .As<IGreeterService>()
                .AsSelf();

            builder.Register(xctx => new HelloController(xctx.Resolve<HelloService>()));
            builder.Register(xctx => new HiController(xctx.Resolve<HiService>()));

            Container = builder.Build();

            return Container;
        }
    }
}