using Microsoft.AspNetCore.Mvc;


namespace DemoMVC.Controllers
{
public class EmployeeController : Controller
{
// GET: /Employee/Index
public IActionResult Index()
{
ViewData["Title"] = "Employee - Index";
return View();
}


// GET: /Employee/Profile
public IActionResult Profile()
{
ViewData["Title"] = "Employee - Profile";
return View();
}
}
}