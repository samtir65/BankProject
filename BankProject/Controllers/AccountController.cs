using Microsoft.AspNetCore.Mvc;

namespace BankProject.Controllers;

public class AccountController : Controller
{
    // post
    [HttpPost]
    public IActionResult Index()
    {
        return View();
    }
}