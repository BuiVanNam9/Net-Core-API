using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(PersonModel model)
        {
            if (ModelState.IsValid)
                return View("Result", model);

            return View();
        }
    }
}
