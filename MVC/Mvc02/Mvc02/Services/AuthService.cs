using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Mvc02.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc02.Services
{
    public class AuthService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AuthService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        internal async Task<bool> UserExist(string email)
        {
            IdentityUser user = await _userManager.FindByEmailAsync(email);
            return user != null;
        }

        internal async Task<bool> RoleExist(string roleName)
        {
            IdentityRole role = await _roleManager.FindByNameAsync(roleName);
            return role != null;
        }

        internal async Task CreateRole(string roleName)
        {
            IdentityResult role;
            role = await _roleManager.CreateAsync(new IdentityRole(roleName));
        }

        public async Task ConnectRoleToUser(string roleName, string email)
        {
            IdentityUser user = await _userManager.FindByEmailAsync(email);

            if (user != null)
            {
                await _userManager.AddToRoleAsync(user, roleName);
            }
        }
    }
}
