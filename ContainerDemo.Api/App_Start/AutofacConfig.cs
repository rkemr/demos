namespace ContainerDemo.Api
{
    using Autofac;
    using Autofac.Integration.WebApi;
    using System.Reflection;

    public static class AutofacConfig
    {
        public static IContainer BuildContainer(ContainerBuilder builder)
        {
            return builder
                .RegisterServices()
                .RegisterControllers()
                .Build();
        }

        public static ContainerBuilder RegisterServices(this ContainerBuilder builder)
        {
            builder.RegisterType<ContainerDemo.Services.BoysNamesService>().As<ContainerDemo.Interfaces.INamesService>().InstancePerLifetimeScope();

            return builder;
        }

        public static ContainerBuilder RegisterControllers(this ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            return builder;
        }
    }
}