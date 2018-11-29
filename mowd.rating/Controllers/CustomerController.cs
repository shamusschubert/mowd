using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mowd.rating.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet()]
        [ActionName("GetCustomerRating")]
        [Route("customer")]
        public async Task<IActionResult> GetCustomerRating()
        {
            List<int> list = new List<int>();

            for(int i = 0;i<100;i++)
            {
                list.Add(i);
            }

            return Ok(list);
        }


        [HttpGet()]
        [ActionName("GetCustomerRatingById")]
        [Route("customer/{id}")]
        public async Task<IActionResult> GetCustomerRatingById(Guid id)
        {
            return Ok(id);
        }
    }
}
