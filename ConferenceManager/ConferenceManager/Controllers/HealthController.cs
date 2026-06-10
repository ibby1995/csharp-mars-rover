using Microsoft.AspNetCore.Mvc;

namespace ConferenceAPI.Controllers
{
    [Route("/health")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHealth()
        {
            return Ok("Server is up and running!");
        }
    }
}
