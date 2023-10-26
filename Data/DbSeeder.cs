using ASPNETIdentity.Constants;
using ASPNETIdentity.Models;
using Microsoft.AspNetCore.Identity;

namespace ASPNETIdentity.Data
{
    public static class DbSeeder
    {
        public static async Task SeddRolesAndAdminAsync(IServiceProvider service)
        {
            var userManager = service.GetService<UserManager<ApplicationUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));

            var user = new ApplicationUser
            {
                UserName = "Admin@gmail.com",
                Email = "Admin@gmail.com",
                Name = "Admin",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };
            var userInDb = await userManager.FindByEmailAsync(user.Email);
            if(userInDb==null)
            {
                await userManager.CreateAsync(user, "Admin@123");
                await userManager.AddToRoleAsync(user, Roles.Admin.ToString()); 
            }
        }

    }
}
