using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HemNet.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "The name field is required")]
        public string Name { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "The Email field is required")]
        public string Email { get; set; }
    }
}
