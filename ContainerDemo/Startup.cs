using Microsoft.Owin;

[assembly: OwinStartupAttribute(typeof(ContainerDemo.Startup))]
namespace ContainerDemo
{
    using Autofac;
    using Autofac.Integration.Mvc;
    using Owin;
    using System.Web.Mvc;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            var container = AutofacConfig.BuildContainer(builder);

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            app.UseAutofacMiddleware(container);
            app.UseAutofacMvc();
        }
    }
}
