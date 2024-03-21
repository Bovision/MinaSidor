using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using MinaSidor.Server.Models;
using System;
using NuGet.Protocol;
using MinaSidor.Server.ViewModels;



namespace MinaSidor.Server.Controllers
    {
    [Authorize(Roles = "Administrator,admin")]
    [Route("[controller]/[action]")]
    [ApiController]
    public class RoleController : ControllerBase
        {
        readonly RoleManager<IdentityRole> roleManager;
        readonly UserManager<ApplicationUser> userManager;
        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
            {
            this.roleManager = roleManager;
            this.userManager = userManager;

            }
        [HttpGet]
        public string GetRoles()
            {
            return roleManager.Roles.ToJson();

            }
        [HttpGet]
        public string GetUsers()
            {

            return userManager.Users.Select(u => new UserViewModel
                {
                Id = u.Id,
                UserName = u.UserName,
                Email = u.Email,
                PhoneNumber = u.PhoneNumber,
                EmailConfirmed=u.EmailConfirmed,
                PhoneNumberConfirmed=u.PhoneNumberConfirmed,
                TwoFactorEnabled=u.TwoFactorEnabled,
                LockoutEnabled=u.LockoutEnabled,
                AccessFailedCount=u.AccessFailedCount,
                Role = userManager.GetRolesAsync(u).Result,

                
                // Fyll i andra egenskaper här
                }).ToJson();

            }
        [HttpPost]
        public async Task<bool> AddRole(string Name)
            {

            var identityRole = CreateRule();
            identityRole.Name = Name;
           var res= await roleManager.CreateAsync(identityRole);
            return res.Succeeded;
            }
        [HttpGet]
        public async Task<string> ShowUserRole()
            {

            List<UserRole> UserRole = new List<UserRole>();
            foreach (var User in userManager.Users)
                {

                var Roles = new List<string>(await userManager.GetRolesAsync(User));


                UserRole.Add(new UserRole(User.Id, User.UserName, Roles));
                //  vm.UserName = user.UserName;
                }
            return UserRole.ToJson();
            }
        [HttpPost]
        public async Task<bool> DeleteUser(string UserId)
            {
            var UserName = userManager.Users.FirstOrDefault(u => u.Id == UserId).UserName;
            if (UserName != User.Identity.Name)
                {
                if (User.IsInRole("Administrator"))
                    {
                    var User = userManager.Users.FirstOrDefault(u => u.Id == UserId);

                    var result2 = await userManager.DeleteAsync(User);
                    return result2.Succeeded;
                    }
                }
            return false;
                   
            }
        [HttpPost]
        public async Task<bool> ResetPassword(string UserId,string Newpass)
            {
            var UserName = userManager.Users.FirstOrDefault(u => u.Id == UserId).UserName;
            if (UserName != User.Identity.Name)
                {
                PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();
                var User = userManager.Users.FirstOrDefault(u => u.Id == UserId);
                User.PasswordHash = hasher.HashPassword(null, Newpass);

                var result2 = await userManager.UpdateAsync(User);
                return result2.Succeeded;   
                }
            return false;
            }
        [HttpPost]
        public async Task<bool> DeleteRole(string Id)
            {
            var role = roleManager.Roles.FirstOrDefault(u => u.Id == Id);

            var result2 = await roleManager.DeleteAsync(role);
            return result2.Succeeded;

            }
        [HttpPost]
        public async Task<bool> DeleteRoleUser(string Role, string UserId)
            {
            
            var user = await userManager.FindByIdAsync(UserId);
            if (!Role.Equals("Administrator")|| User.IsInRole("Administrator"))
                {
                var res =await userManager.RemoveFromRoleAsync(user, Role);
                return res.Succeeded;
                }
                return false;   
            }
        [HttpPost]
        public async Task<bool> AddUserRole(string UserName, string Role)
            {
            var username = userManager.Users.FirstOrDefault(u => u.UserName == UserName);
            if (User.IsInRole("Administrator") || User.IsInRole("admin") && !Role.Equals("Administrator"))
                {
               var res= await userManager.AddToRoleAsync(username, Role);
                return res.Succeeded;
                }
            else if (User.IsInRole("Administrator") && Role.Equals("Administrator"))
                {
                var res = await userManager.AddToRoleAsync(username, Role);
                return res.Succeeded;
                }
    
            return false;
            }

        private IdentityRole CreateRule()
            {
            try
                {
                return Activator.CreateInstance<IdentityRole>();
                }
            catch
                {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(IdentityRole)}'. " +
                    $"Ensure that '{nameof(IdentityRole)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in Role.cshtml");
                }
            }

        }
    }
