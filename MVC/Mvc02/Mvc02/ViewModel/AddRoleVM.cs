using Microsoft.AspNetCore.Mvc.Rendering;
using Mvc02.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc02.ViewModel
{
    public class AddRoleVm
    {
        [Required(ErrorMessage = "Du ska skriva nått här din fillidutt")]
        public string RoleName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
    }
}
