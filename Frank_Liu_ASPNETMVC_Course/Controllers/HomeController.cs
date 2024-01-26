using Microsoft.AspNetCore.Mvc;

namespace Frank_Liu_ASPNETMVC_Course.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}