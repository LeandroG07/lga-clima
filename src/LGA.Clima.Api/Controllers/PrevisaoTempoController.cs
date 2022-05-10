using Microsoft.AspNetCore.Mvc;

namespace LGA.Clima.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PrevisaoTempoController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Api OK!");
        }


    }
}
