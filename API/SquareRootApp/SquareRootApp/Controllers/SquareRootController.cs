using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquareRootApp.Controllers
{
    [Route("api")]
    public class SquareRootController : Controller
    {
        [HttpGet("SquareRoot")]
        public IActionResult SquareRoot(int? number)
        {
            if (number == null)
                return BadRequest("Du måste ange ett tal! ");

            if (number < 0)
                return BadRequest("Tal måste vara positivt");

            return Ok(Math.Sqrt((int)number));
        }


    }
}
