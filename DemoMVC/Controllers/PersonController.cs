using Microsoft.AspNetCore.Mvc;


namespace DemoMVC.Controllers
{
public class PersonController : Controller
{
// GET: /Person/Index
public IActionResult Index()
{
// (Optional) set a title for the view
ViewData["Title"] = "Person - Index";
return View();
}


// GET: /Person/Details
public IActionResult Details()
{
ViewData["Title"] = "Person - Details";
return View();
}
}
}