using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController: Controller
{
    [HttpGet]
    [ProducesResponseType(200)]
    public IActionResult Index()
    {
        return View("Index");
    }
    
}