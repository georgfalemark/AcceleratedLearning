using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLabb.Models;

namespace WebApiLabb.Controllers
{
    [Route("webapi1")]
    public class WebApi1Controller : Controller
    {
        [Route("AddPlanet")]
        public IActionResult AddPlanet()
        {
            string formContent = "";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                formContent = reader.ReadToEndAsync().Result;
            }

            // Du behöver göra "Planet"-klassen och metoden "ParsePlanet"
            Planet planet = ParsePlanet(formContent);

            return Ok($"Ny planet {planet.Name} skapad med storleken {planet.Size}");
        }

        public Planet ParsePlanet(string formContent)
        {
            string[] planet = formContent.Split('&');

            string x = planet[0];
            string[] name = x.Split('=');

            string y = planet[1];
            string[] size = y.Split('=');

            var p = new Planet();

            p.Name = name[1];
            p.Size = int.Parse(size[1]);

            return p;
        }

        //public Planet _ParsePlanet(string formContent)
        //{
        //    Planet p = formContent.Split('&')
        //        .Select(fc => fc.Split('='))
        //        .Select(p1 => new Planet { Name = p1[1], Size = int.Parse(p1[1]) })
        //        .Single();

        //    return p;
        //}



        [Route("GetPlanet")]
        public IActionResult GetPlanet()
        {
            string formContent = "";

            formContent = Request.QueryString.Value;

            Planet planet = ParsePlanet(formContent);

            return Ok($"Söker i databasen efter planeter med namn {planet.Name} och storlek {planet.Size}");
        }

        [HttpPost("AddPlanet2")]
        public IActionResult AddPlanet2(Planet planet)
        {
            return Ok($"Ny planet {planet.Name} skapad med storleken {planet.Size}");
        }

        [HttpGet("GetPlanet2")]
        public IActionResult GetPlanet2(Planet planet)
        {
            return Ok($"Söker i databasen efter planeter med namn {planet.Name} och storlek {planet.Size}");
        }






    }
}
