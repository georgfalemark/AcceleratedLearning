using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApiLabb.Controllers
{
    [Route("webapi4")]
    public class WebApi4Controller : Controller
    {
        [HttpGet("chocolate")]
        public IActionResult Chocolate(decimal nrPersons)
        {
            if (nrPersons <= 0)
                return BadRequest("Du måste ju ange en person");

            decimal chocolatebar = 25;
            decimal piecesPerPerson = chocolatebar / nrPersons;

            return Ok($"Alle får {piecesPerPerson.ToString("0.##")} bitar choklad per person");
        }

        [HttpGet("order")]
        public IActionResult Order(string orderNr)
        {
            if (String.IsNullOrWhiteSpace(orderNr))
                return BadRequest("Du har inte angett något! ");

            string[] numberAndLetter = orderNr.Split('-');

            int number = 0;

            try
            {
                number = int.Parse(numberAndLetter[1]);
            }
            catch (Exception)
            {
                return BadRequest("Nu angav du nått helgalet din fillidutt! ");
            }

            if (number > 3000)
                return NotFound("Hittade inte ordern (siffran för stor!) ");

            Regex rgx = new Regex(@"^[a-zA-Z][a-zA-Z]-[0-9][0-9][0-9][0-9]$");
            if (rgx.IsMatch(orderNr))
            {
                return Ok($"order {orderNr} hittades i databasen");
            }
            else
            {
                return BadRequest("Fel format! (vänligen ange i format 'XX-1111' ");
            }
        }

        [HttpGet("username")]
        public IActionResult CheckUsername(string username)
        {
            if (String.IsNullOrWhiteSpace(username))
                return BadRequest("Du har inte angett något! ");

            username.Trim();
            username.ToLower();

            if (username == "stewie")
            {
                return BadRequest("DATA ERROR");
            }
            else if (username == "peter")
            {
                string html = "<img src='https://cdn.shopify.com/s/files/1/1061/1924/products/7_large.png?v=1544200556'/>";
                return Content(html, "text/html");
            }
            else if (username == "lois" || username == "meg" || username == "chris" || username == "brian")
            {
                string html = "<img src='https://emojipedia-us.s3.dualstack.us-west-1.amazonaws.com/thumbs/120/apple/155/thumbs-up-sign_1f44d.png'/>";
                return Content(html, "text/html");
            }
            else
            {
                string html = "<img src='https://cdn.shopify.com/s/files/1/1061/1924/products/Thumbs_Down_Sign_Emoji_Icon_ios10_large.png?v=1542435999'/>";
                return Content(html, "text/html");
            }
        }

        [HttpGet("lamp")]
        public IActionResult TurnLightOn(bool lampOn)
        {
            if (lampOn == true)
            {
                string html = "<img src='http://www.clker.com/cliparts/O/Y/B/C/t/1/light-bulb-on-md.png'/>";
                return Content(html, "text/html");
            }
            else
            {
                string html = "<img src='https://images.homedepot-static.com/productImages/763b0433-97f4-4e21-aa95-64c04282a43b/svn/smart-electric-led-bulbs-826-64_1000.jpg'/>";
                return Content(html, "text/html");
            }
        }

        [HttpGet("lamp2")]
        public IActionResult TurnLightOn2(bool lampOn)
        {
            if (lampOn == true)
            {
                string html = "<img src='http://www.clker.com/cliparts/O/Y/B/C/t/1/light-bulb-on-md.png'/>";
                return Content(html, "text/html");
            }
            else
            {
                string html = "<img src='https://images.homedepot-static.com/productImages/763b0433-97f4-4e21-aa95-64c04282a43b/svn/smart-electric-led-bulbs-826-64_1000.jpg'/>";
                return Content(html, "text/html");
            }
        }
    }
}
