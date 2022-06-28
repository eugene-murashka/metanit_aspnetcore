using Microsoft.AspNetCore.Mvc;

namespace metanit_asp_net_core.API.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
