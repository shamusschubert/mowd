using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mowd.rating.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet()]
        [Route("api/customer/{id}")]
        public async Task<IActionResult> GetCustomerRatingById(Guid Id)
        {
            return Ok();
        }
    }
}
