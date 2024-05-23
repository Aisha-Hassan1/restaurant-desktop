using Microsoft.AspNetCore.Mvc;

namespace ProF.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
