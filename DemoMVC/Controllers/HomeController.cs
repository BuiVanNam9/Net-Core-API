using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo/Index
        public IActionResult Index()
        {
            return View();
        }

        // POST: Demo/Index
        [HttpPost]
        public IActionResult Index(string FullName, string Address)
        {
            string strOutput = "Xin chào " + FullName + " đến từ " + Address;
            ViewBag.Message = strOutput;
            return View();
        }
    }
}
