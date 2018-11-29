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
            var results = new List<RequestModel>();

            results.Add(new RequestModel { Address = "123 Main Street", Blow = true, City = "Matthews", Edge = true, Mow = true, NeedBy = new DateTime(2018, 11, 29), NoEarlierThan = 9, NoLaterThan = 18, Pets = true, Phone = "7049994363", PostalCode = "28104", SpecialInstructions = "Make sure to close gate", State = "NC" });
            results.Add(new RequestModel { Address = "123 Main Street", Blow = true, City = "Matthews", Edge = true, Mow = true, NeedBy = new DateTime(2018, 11, 29), NoEarlierThan = 9, NoLaterThan = 18, Pets = true, Phone = "7049994363", PostalCode = "28104", SpecialInstructions = "Make sure to close gate", State = "NC" });
            results.Add(new RequestModel { Address = "123 Main Street", Blow = true, City = "Matthews", Edge = true, Mow = true, NeedBy = new DateTime(2018, 11, 29), NoEarlierThan = 9, NoLaterThan = 18, Pets = true, Phone = "7049994363", PostalCode = "28104", SpecialInstructions = "Make sure to close gate", State = "NC" });

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
        public async Task<IActionResult> CreateRequest([FromBody]RequestModel Model)
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
