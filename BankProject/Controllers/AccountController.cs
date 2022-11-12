using Microsoft.AspNetCore.Mvc;

namespace BankProject.Controllers;

public class AccountController : Controller
{
    // post
    [HttpPost]
    [Route("[controller]")]
    public IActionResult Index()
    {
        return View();
    }
}