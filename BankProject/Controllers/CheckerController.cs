using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankProject.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CheckerController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "X";
        }

        [HttpGet]
        public string Name()
        {
            return "Mohammad";
        }
    }
}
