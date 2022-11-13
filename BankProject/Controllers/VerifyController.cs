using Microsoft.AspNetCore.Mvc;

namespace BankProject.Controllers;

public class VerifyController : Controller
{
    // Post
    [HttpPost]
    public IActionResult Index()
    {
        return View();
    }
}