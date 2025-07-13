using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "values1", "values2" };
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok($"Received: {value}");
        }
    }
}