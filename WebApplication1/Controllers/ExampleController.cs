using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class ExampleController : Controller
{
    [HttpGet]
    public IActionResult Get()
    {
        return View("Index");
    }
}