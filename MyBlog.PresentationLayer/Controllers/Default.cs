using Microsoft.AspNetCore.Mvc;

namespace MyBlog.PresentationLayer.Controllers;

public class Default : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}