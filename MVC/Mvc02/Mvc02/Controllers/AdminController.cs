using Microsoft.AspNetCore.Mvc;
using Mvc02.Services;
using Mvc02.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc02.Controllers
{
    public class AdminController : Controller
    {
        private readonly AuthService _auth;

        public AdminController(AuthService auth)
        {
            _auth = auth;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddRoleForUser(AddRoleVm addrole)
        {
            if (!ModelState.IsValid)
                return View("Index");

            bool userExist = await _auth.UserExist(addrole.Email);

            bool roleExist = await _auth.RoleExist(addrole.RoleName);

            if (!userExist)
            {
                ModelState.AddModelError("UserDontExist", "Användaren finns inte! ");
                return View("Index");
            }
            else if (!roleExist)
            {
                await _auth.CreateRole(addrole.RoleName);

                await _auth.ConnectRoleToUser(addrole.RoleName, addrole.Email);
            }

            return View("SuccessAddRole");

        }
    }
}
