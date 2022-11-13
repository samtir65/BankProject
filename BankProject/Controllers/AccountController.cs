using Microsoft.AspNetCore.Mvc;

namespace BankProject.Controllers;

public class AccountController : Controller
{
    // post
    [HttpGet]
    [Route("[api/account]")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    [Route("[controller]/Mamad")]

    public string Mamad()
    {
        return "Mamad";
    }

    private string Samira()
    {
        return "Samira";
    }
}