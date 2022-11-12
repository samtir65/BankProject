using Microsoft.AspNetCore.Mvc;

namespace BankProject.Controllers;

public class AccountController : Controller
{
    // post
    [HttpGet]
    [Route("[controller]")]
    public IActionResult Index()
    {
        return View();
    }
}