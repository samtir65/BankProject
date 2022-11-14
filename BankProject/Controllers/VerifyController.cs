using Microsoft.AspNetCore.Mvc;

namespace BankProject.Controllers;

[ApiController]
[Route("api/Verify")]
public class VerifyController : Controller
{
    // Post
    [HttpPost]
    [Route("RegisterAccount")]
    public IActionResult Index()
    {
        return View();
    }
}