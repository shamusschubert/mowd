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
    public class BidController : ControllerBase
    {
        [HttpGet()]
        [Route("bid")]
        public async Task<IActionResult> ListBids()
        {
            return Ok();
        }

        [HttpGet()]
        [Route("bid/{id}")]
        public async Task<IActionResult> GetBidById(Guid id)
        {
            return Ok();
        }

        [HttpPost()]
        [Route("bid")]
        public async Task<IActionResult> CreateBid([FromBody]BidModel Model)
        {
            return Created("", Model);
        }

        [HttpDelete()]
        [Route("bid")]
        public async Task<IActionResult> DeleteBid(Guid id)
        {
            return StatusCode(StatusCodes.Status204NoContent);
        }
    }
}
