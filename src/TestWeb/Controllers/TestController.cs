using Microsoft.AspNetCore.Mvc;

namespace TestWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        [HttpGet("probe")]
        public IActionResult Get()
        {
            return Ok("hello world from github!");
        }
    }
}
