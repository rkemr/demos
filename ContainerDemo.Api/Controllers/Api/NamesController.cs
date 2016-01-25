namespace ContainerDemo.Api.Controllers.Api
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Web.Http;

    [RoutePrefix("api/names")]
    public class NamesController : ApiController
    {
        private readonly INamesService namesService;

        public NamesController(INamesService namesService)
        {
            this.namesService = namesService;
        }

        [Route("")]
        public IEnumerable<string> GetNames(int howMany)
        {
            return this.namesService.GetTopNames(howMany);
        }
    }
}