using Microsoft.AspNetCore.Mvc;
using MvcAppDemo.Models;

namespace MvcAppDemo.Controllers
{
    public class Bai1Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Bai1Model model)
        {
            if (ModelState.IsValid)
            {
                return View("KetQua", model);
            }
            return View();
        }
    }
}
