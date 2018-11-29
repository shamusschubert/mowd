using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mowd.rating.Controllers
{
    [ApiController]
    public class JobController : ControllerBase
    {
        [HttpGet()]
        [Route("job")]
        public async Task<IActionResult> GetJobRatings()
        {
            return Ok("Job ratings");
        }

        [HttpGet()]
        [Route("job/{id}")]
        public async Task<IActionResult> GetJobRatingById(Guid id)
        {
            return Ok("Just one job rating");
        }
    }
}
