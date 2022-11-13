using Microsoft.AspNetCore.Mvc;

namespace BankProject.Controllers;

public class AccountController : Controller
{
    // post
    [HttpGet]
    [Route("api/[controller]")]
    public string Index()
    {
        return "Empty Index";
    }


    [HttpGet]
    [Route("api/[controller]/Mamad")]
    public string Mamad()
    {
        return "Mamad";
    }

    private string Samira()
    {
        return "Samira";
    }

    private void VsTest()
    {
        int a = 10;
    }
}