using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();   // gọi tới View Index.cshtml
        }
    }
}
