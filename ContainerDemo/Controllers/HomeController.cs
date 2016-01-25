namespace ContainerDemo.Controllers
{
    using System.Web.Mvc;
    using ContainerDemo.Interfaces;
    using ContainerDemo.Models;
    using Autofac.Extras.Attributed;

    public class HomeController : Controller
    {
        private readonly INamesService namesService;

        public HomeController(INamesService namesService)
        {
            this.namesService = namesService;
        }

        public ActionResult Index()
        {
            var model = new HomePageModel();

            model.TopNames = this.namesService.GetTopNames();
            
            return View(model);
        }
    }
}