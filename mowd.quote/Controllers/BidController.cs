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
        [Route("api/bids")]
        public async Task<IActionResult> ListBids()
        {
            return Ok();
        }

        [HttpGet()]
        [Route("api/bids/{id}")]
        public async Task<IActionResult> GetBidById(Guid Id)
        {
            return Ok();
        }

        [HttpPost()]
        [Route("api/bids")]
        public async Task<IActionResult> CreateBid([FromBody]BidModel Model)
        {
            return Created("", Model);
        }

        [HttpDelete()]
        [Route("api/bids")]
        public async Task<IActionResult> DeleteBid(Guid Id)
        {
            return StatusCode(StatusCodes.Status204NoContent);
        }
    }
}
