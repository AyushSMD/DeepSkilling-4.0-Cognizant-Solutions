using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private static readonly List<string> values = new List<string>
        {
            "values1", "values2", "values3"
        };

        // GET: api/values
        [HttpGet]
        [ActionName("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<string>> Get()
        {
            return values;
        }

        // GET: api/values/1
        [HttpGet("{id}")]
        [ActionName("GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<string> Get(int id)
        {
            if (id < 0 || id >= values.Count)
                return NotFound($"No value found at index {id}.");

            return Ok(values[id]);
        }

        // POST: api/values
        [HttpPost]
        [ActionName("PostValue")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return BadRequest("Value cannot be empty.");

            // Optional: Add to list
            // values.Add(value);

            return Ok($"Received: {value}");
        }
    }
}
