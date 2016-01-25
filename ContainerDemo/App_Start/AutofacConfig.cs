namespace ContainerDemo
{
    using Autofac;
    using Autofac.Extras.Attributed;
    using Autofac.Integration.Mvc;

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
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
    
            return builder;
        }
    }
}


// builder.RegisterType<ContainerDemo.Services.Localized.LocalizedBoysNamesService>().Keyed<ContainerDemo.Interfaces.INamesService>("Localized").InstancePerLifetimeScope();
// .WithAttributeFilter();