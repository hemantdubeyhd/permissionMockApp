using Microsoft.AspNetCore.Mvc;

namespace PermissionApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult GetHello()
        {
            return Ok(new { message = "Hello from backend!" });
        }

    }
}
