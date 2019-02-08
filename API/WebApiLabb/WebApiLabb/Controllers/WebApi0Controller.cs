using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiLabb.Controllers
{
    [Route("webapi0")]
    public class WebApi0Controller : Controller
    {
        [Route("kalle")]
        public string Kalle()
        {
            return "Hej från servern!";
        }

        [Route("kalle2")]
        public string Kalle2()
        {
            return "Klockan är " + System.DateTime.Now;
        }

        [Route("kalle3")]
        public int Kalle3()
        {
            int i = 100 * 2;
            return i;
        }

        //[Route("kalle4"), HttpGet] //eller HttpPost
        [HttpGet("kalle4")]
        public IActionResult Kalle4()
        {
            //return BadRequest();
            //return NotFound();
            return Ok("Klockan är " + System.DateTime.Now);
        }


    }
}
