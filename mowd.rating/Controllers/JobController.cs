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
        [Route("api/job/{id}")]
        public async Task<IActionResult> GetJobRatingById(Guid Id)
        {
            return Ok();
        }
    }
}
