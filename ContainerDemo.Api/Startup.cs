using Microsoft.Owin;

[assembly: OwinStartupAttribute(typeof(ContainerDemo.Api.Startup))]
namespace ContainerDemo.Api
{
    using Autofac;
    using Autofac.Integration.WebApi;
    using Owin;
    using System.Web.Http;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            WebApiConfig.Register(config);

            var builder = new ContainerBuilder();

            var container = AutofacConfig.BuildContainer(builder);

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            app.UseAutofacMiddleware(container);
            app.UseAutofacWebApi(config);
            app.UseWebApi(config);
        }
    }
}
