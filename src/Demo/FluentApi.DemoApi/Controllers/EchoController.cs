using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluentApi.DemoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EchoController : ControllerBase
    {
        [HttpGet("{message}")]
        public IActionResult Get(string message) => Ok(new { Echo = message });

        [HttpPost]
        public IActionResult Post([FromBody] object data) => Ok(new { Received = data });
    }

}
