using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HemNet.Models;
using Microsoft.AspNetCore.Mvc;


namespace HemNet.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index([Bind("Name,Email")] Contact c)
        {
            return View(c);
        }

        public IActionResult Thanks(Contact c)
        {
            return View(c);
        }
    }
}
