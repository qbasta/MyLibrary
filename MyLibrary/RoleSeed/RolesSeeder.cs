using Microsoft.AspNetCore.Identity;
using MyLibrary.Models;
using System;

namespace MyLibrary.RoleSeed
{
    public static class RolesSeeder
    {
        public static void Seed(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync(Roles.SuperAdmin.ToString()).Result)
            {
                var role = new IdentityRole
                {
                    Name = Roles.SuperAdmin.ToString()
                };

                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync(Roles.Administrator.ToString()).Result)
            {
                var role = new IdentityRole
                {
                    Name = Roles.Administrator.ToString()
                };

                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync(Roles.Moderator.ToString()).Result)
            {
                var role = new IdentityRole
                {
                    Name = Roles.Moderator.ToString()
                };

                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync(Roles.User.ToString()).Result)
            {
                var role = new IdentityRole
                {
                    Name = Roles.User.ToString()
                };

                var result = roleManager.CreateAsync(role).Result;
            }
        }
        private static void SeedUsers(UserManager<ApplicationUser> userManager)
        {
            if (userManager.FindByEmailAsync("superadmin@admin.com").Result is null)
            {
                var user = new ApplicationUser
                {
                    UserName = "superadmin",
                    Email = "superadmin@admin.com",
                    FirstName = "Super",
                    LastName = "Admin",
                    ProfilePicture = null,
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true
                };


                var result = userManager.CreateAsync(user, "Password123.").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, Roles.SuperAdmin.ToString()).Wait();
                    var token = userManager.GenerateEmailConfirmationTokenAsync(user);
                    userManager.ConfirmEmailAsync(user, token.Result);
                    user.EmailConfirmed = true;
                }
            }
        }
    }
}
