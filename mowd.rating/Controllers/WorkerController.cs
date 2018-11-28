using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mowd.rating.Controllers
{
    [ApiController]
    public class WorkerController : ControllerBase
    {
        [HttpGet()]
        [Route("api/worker/{id}")]
        public async Task<IActionResult> GetWorkerRatingById(Guid Id)
        {
            return Ok();
        }
    }
}
