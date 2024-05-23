using Microsoft.AspNetCore.Mvc;
using ProF.Models;
using System.Diagnostics;

namespace ProF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult page1()
        {
            return View();
        }
        public IActionResult page2()
        {
            return View();
        }

        public IActionResult page3login()
        {
            return View();
        }
        public IActionResult page3login2(string firstName, string lastName, int idNumber)
        {
            TempData["fname"] = firstName;
            TempData["lname"] = lastName;
            TempData["tnumber"] = idNumber;

            // حفظ القيم في TempData لفترة أطول
            TempData.Keep("fname");
            TempData.Keep("lname");
            TempData.Keep("tnumber");

            return RedirectToAction("page4wellcome");
        }


        public IActionResult page4wellcome()
        {
            ViewBag.fname = TempData["fname"];
            ViewBag.lname = TempData["lname"];
            ViewBag.tnumber = TempData["tnumber"];

            // حفظ القيم في TempData لفترة أطول
            TempData.Keep("fname");
            TempData.Keep("lname");
            TempData.Keep("tnumber");

            return View();
        }
        public IActionResult page5sbc()
        {
            return View();
        }
         public IActionResult page6menu()
        {
            return View();
        }
         public IActionResult page7share()
        {
            return View();
        }
         public IActionResult page8thank()
        {
            return View();
        }
         
         public IActionResult page9apps()
        {
            return View();
        }
        public IActionResult page10offers()
        {
            return View();
        }
        public IActionResult page11s_f()
        {
            return View();
        }
         public IActionResult page12cart()
        {
            return View();
        }
        public IActionResult page13payment()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}