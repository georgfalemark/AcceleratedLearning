using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiLabb.Controllers
{
    [Route("webapi6")]
    public class WebApi6Controller : Controller
    {
        [HttpPost("AddDocument")]
        public IActionResult AddDocument(Document document)
        {
            return Ok(document);
        }

        public class Document
        {
            public string Title { get; set; }
            public int numberOfPages { get; set; }
            public bool hasSummary { get; set; }
            public DateTime publishedFrom { get; set; }
            public decimal price { get; set; }
            public string type { get; set; }
            public List<String> tagList { get; set; }
            public int rating { get; set; }
        }
    }
}
