using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiLabb.Controllers
{
    [Route("webapi5")]
    public class WebApi5Controller : Controller
    {
        [HttpPost("Person")]
        public IActionResult addPerson(string name, int age)
        {
            return Ok($"{name} som är {age} år lades till i databasen");
        }

        [HttpPost("Person2")]
        public IActionResult addPerson2(string name, string age)
        {
            if (String.IsNullOrWhiteSpace(name) && String.IsNullOrWhiteSpace(age))
                return BadRequest("Förnamn och ålder är obligatoriskt");

            if (String.IsNullOrWhiteSpace(name))
                return BadRequest("Förnamn är obligatoriskt");

            if (String.IsNullOrWhiteSpace(age))
                return BadRequest("Ålder är obligatoriskt");

            int _age;
            try
            {
                _age = int.Parse(age);
            }
            catch (Exception)
            {
                return BadRequest("Du angav inte en siffra din fillidutt! ");
            }

            if (name.Length > 20)
                return BadRequest("Förnamnet får inte vara längre än 20 tecken.");

            if (_age < 0 || _age > 120)
                return BadRequest("Åldern måste vara mellan 0 & 120 år din fillidutt! ");

            return Ok($"{name} som är {age} år lades till i databasen");
        }

        [HttpPost("Person3")]
        public IActionResult addPerson3(Person person)
        {
            if (ModelState.IsValid)
                return Ok($"{person.name} som är {person.age} år lades till i databasen");
            else
                return BadRequest(ModelState);
        }

        public class Person
        {
            [Required]
            [StringLength(20, MinimumLength = 2)]
            public string name { get; set; }

            [Required]
            [Range(0, 120)]
            public int? age { get; set; }
        }

        [HttpPost("Person4")]
        public IActionResult addPerson4(Person2 person)
        {
            if (ModelState.IsValid)
                return Ok($"{person.name} som är {person.age} år lades till i databasen");
            else
                return BadRequest(ModelState);
        }

        public class Person2
        {
            [Required]
            [RegularExpression(@"[a-zA-Z]{2,20}$")]
            public string name { get; set; }

            [Required]
            [RegularExpression(@"^0*(?:[1-9][0-9]?[0-9]?|120)$")]
            public int? age { get; set; }
        }







    }
}
