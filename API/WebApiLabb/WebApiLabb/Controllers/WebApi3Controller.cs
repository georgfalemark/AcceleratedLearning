using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiLabb.Controllers
{
    [Route("webapi3")]
    public class WebApi3Controller : Controller
    {
        [HttpGet("Breakfast")]
        public IActionResult Breakfast(string food)
        {
            string foodToLower = food.ToLower();
            if (foodToLower == "mango")
            {
                return Ok("Mango är gytt!");
            }
            else
            {
                return Ok($"{food} är äckligt ");
            }
        }

        [HttpGet("Number")]
        public IActionResult numberToRedo(int number)
        {
            int sum = number * number;
            return Ok($"{number} * {number} = {sum}");
        }

        [HttpGet("NumberList")]
        public IActionResult numberList(int StartNumber, int EndNumber)
        {
            List<int> list = new List<int>();

            for (int i = StartNumber; i <= EndNumber; i++)
            {
                list.Add(i);
            }

            string x = String.Join(",", list);
            return Ok(x);
        }



        [HttpGet("ChangeBackground")]
        public IActionResult ChangeBackground(string BackgroundColor)
        {
            string html = $"<!DOCTYPE html><html><body style = 'background-color: {BackgroundColor}'></body></html>";
            return Content(html, "text/html");
        }

        








    }
}
