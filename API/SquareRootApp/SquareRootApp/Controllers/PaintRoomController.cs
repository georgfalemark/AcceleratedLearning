using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquareRootApp.Controllers
{
    [Route("api")]
    public class PaintRoomController : Controller
    {
        [HttpGet("PaintRoom")]
        public IActionResult PaintRoom(int? number, string color, int? height)
        {
            if (String.IsNullOrWhiteSpace(color))
                return BadRequest("Du måste ange en färg! ");

            int colorFactor = getColorFactor(color);

            if (number == null)
                return BadRequest("Du måste ange ett tal som storlek på rummet! ");

            if (number < 0)
                return BadRequest("Storleken måste vara positivt");

            if (height == null)
                return BadRequest("Du måste ange ett tal som höjden på rummet! ");

            if (height < 0)
                return BadRequest("Höjden måste vara positivt");

            int? heightFactor = changeDependingOnHeight(height);

            return Ok($"Rummet kommer att kosta {number*colorFactor*heightFactor} KR att måla om");



            //if (color != "blue" && color != "red" && color != "green" && color != "black")
            //    return BadRequest("Det är ingen färg vi känner till! ");

            //switch (color)
            //{
            //    case "blue":
            //        return Ok($"Rummet kommer kosta {number * 2} KR att måla om");
            //    case "red":
            //        return Ok($"Rummet kommer kosta {number * 3} KR att måla om");
            //    case "green":
            //        return Ok($"Rummet kommer kosta {number * 4} KR att måla om");
            //    case "black":
            //        return Ok($"Rummet kommer kosta {number * 5} KR att måla om");
            //    default:
            //        return BadRequest("Hittade inte färgen");
            //}
        }

        private int? changeDependingOnHeight(int? height)
        {
            int? x = height * 2;
            return x;
        }

        private int getColorFactor(string inputColor)
        {

            string newInputColor = MakeFirstCharacterTopper(inputColor);

            List<string[]> colorList = new List<string[]>();

            colorList.Add(new String[] { "255", "0", "0", "Red" });
            colorList.Add(new String[] { "255", "255", "255", "White" });
            colorList.Add(new String[] { "128", "128", "128", "Gray" });
            colorList.Add(new String[] { "0", "255", "0", "Lime" });
            colorList.Add(new String[] { "0", "0", "255", "Blue" });
            colorList.Add(new String[] { "255", "255", "0", "Yellow" });
            colorList.Add(new String[] { "0", "255", "255", "Aqua" });
            colorList.Add(new String[] { "192", "192", "192", "Silver" });
            colorList.Add(new String[] { "255", "0", "255", "Magenta" });
            colorList.Add(new String[] { "128", "0", "0", "Maroon" });
            colorList.Add(new String[] { "128", "128", "0", "Olive" });
            colorList.Add(new String[] { "0", "128", "0", "Green" });
            colorList.Add(new String[] { "128", "0", "128", "Purple" });
            colorList.Add(new String[] { "0", "0", "128", "Navy" });
            colorList.Add(new String[] { "139", "0", "0", "Dark red" });
            colorList.Add(new String[] { "165", "42", "42", "Brown" });
            colorList.Add(new String[] { "255", "99", "71", "Tomato" });
            colorList.Add(new String[] { "255", "69", "0", "Orange" });
            colorList.Add(new String[] { "255", "215", "0", "Gold" });

            foreach (string[] color in colorList)
            {
                if (newInputColor == color[3])
                {
                    int one = int.Parse(color[0]);
                    int two = int.Parse(color[1]);
                    int three = int.Parse(color[2]);
                    int sum = one + two + three;
                    return sum;
                }
            }
            int standardKostnad = 100;
            return standardKostnad;
        }

        private string MakeFirstCharacterTopper(string inputColor)
        {
            string upperCaseString = inputColor.First().ToString().ToUpper() + inputColor.Substring(1);
            return upperCaseString;
        }
    }
}
