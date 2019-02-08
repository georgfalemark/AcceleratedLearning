using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiLabb.Controllers
{
    [Route("webapi2")]
    public class WebApi2Controller : Controller
    {
        [HttpGet("HelloWorld")]
        public IActionResult HelloWorld()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 3);

            if (random == 1)
            {
                return Ok($"Hello World");
            }
            else if (random == 2)
            {
                return Ok("Hei maailma");
            }
            else
            {
                return Ok("Bonjour");
            }
        }

        [HttpGet("DayOfWeek")]
        public IActionResult DayOfWeek()
        {
            DateTime now = DateTime.Now;
            DateTime tenYears = now.AddYears(-10);

            return Ok($"Today it is {System.DateTime.Now.DayOfWeek} and ten years ago it was {tenYears.DayOfWeek}");
        }

        [HttpGet("Floskel")]
        public IActionResult Floskel()
        {
            string day = DateTime.Now.DayOfWeek.ToString();

            if (day == "Monday")
            {
                return Ok("Uh-oh. Sounds like somebody’s got a case of the mondays");
            }
            else if (day == "Tuesday")
            {
                return Ok("Uh-oh. Sounds like somebody’s got a case of the tuesday's");
            }
            else if (day == "Wedsneday")
            {
                return Ok("Uh-oh. Sounds like somebody’s got a case of the wedsneday's");
            }

            return Ok("Funkar inte :( ");
        }

    }
}
