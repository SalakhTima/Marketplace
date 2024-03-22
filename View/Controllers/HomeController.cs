using Microsoft.AspNetCore.Mvc;

namespace View.Controllers;

[Route("/home")]
public class HomeController : Controller
{
    [Route("index")]
    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }
}
