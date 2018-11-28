using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mowd.quote.Models;

namespace mowd.quote.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        [HttpPost()]
        public async Task<IActionResult> Request([FromBody]RequestModel Model)
        {
            if(ModelState.IsValid)
            {
                return Created("/api/quote/" + Model.Id, Model);
            }

            return BadRequest();
        }
    }
}
