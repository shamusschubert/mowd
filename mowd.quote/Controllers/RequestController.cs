using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mowd.quote.Models;

namespace mowd.quote.Controllers
{
    [ApiController]
    public class RequestController : ControllerBase
    {
        [HttpGet()]
        [Route("request")]
        public async Task<IActionResult> ListRequests()
        {
            var results = new List<Request>();

            return Ok(results);
        }

        [HttpGet()]
        [Route("request/{id}")]
        public async Task<IActionResult> GetRequestById(Guid id)
        {
            return Ok();
        }

        [HttpPost()]
        [Route("request")]
        public async Task<IActionResult> CreateRequest([FromBody]Request Model)
        {
            if(ModelState.IsValid)
            {
                var id = Guid.NewGuid();

                return Created("/api/quote/" + id, Model);
            }

            return BadRequest();
        }

        [HttpDelete()]
        [Route("request")]
        public async Task<IActionResult> DeleteRequest(Guid id)
        {
            return StatusCode(StatusCodes.Status204NoContent);
        }

    }
}
