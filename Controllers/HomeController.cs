using System.Web.Mvc;
using MVCKnockoutExample.Models.Home;

namespace MVCKnockoutExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new ExampleViewModel());
        }

    }
}
