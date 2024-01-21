using Autofac;
using System.Reflection;

namespace DependencyInjectionContainersConsole
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            //builder.RegisterType<BusinessLogic>().As<IBusinessLogic>();
            //builder.RegisterType<DataProvider>().As<IDataProvider>();
            //builder.RegisterType<Logger>().As<ILogger>();
            //builder.RegisterType<Application>().As<IApplication>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DependencyInjectionContainersLib))).AsImplementedInterfaces();
            builder.RegisterType<Application>().As<IApplication>();

            return builder.Build();
        }
    }
}
