using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(CalculatorModel model)
        {
            switch (model.Operation)
            {
                case "Add":
                    model.Result = model.Number1 + model.Number2;
                    break;
                case "Sub":
                    model.Result = model.Number1 - model.Number2;
                    break;
                case "Mul":
                    model.Result = model.Number1 * model.Number2;
                    break;
                case "Div":
                    model.Result = model.Number2 != 0 ? model.Number1 / model.Number2 : 0;
                    break;
            }
            return View("Result", model);
        }
    }
}
