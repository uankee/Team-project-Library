using Microsoft.AspNetCore.Identity;
using DataAccess.Data.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Data.Seeding
{
    public static class RoleSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();

            string[] roles = { "Admin", "User" };

            // 🔹 Створення ролей
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole(role));
            }

            // 🔹 Отримання даних адміністратора з середовища
            var adminEmail = Environment.GetEnvironmentVariable("ADMIN_EMAIL");
            var adminPassword = Environment.GetEnvironmentVariable("ADMIN_PASSWORD");

            if (!string.IsNullOrWhiteSpace(adminEmail) && !string.IsNullOrWhiteSpace(adminPassword))
            {
                var admin = await userManager.FindByEmailAsync(adminEmail);
                if (admin == null)
                {
                    var newAdmin = new User
                    {
                        UserName = adminEmail,
                        Email = adminEmail,
                        EmailConfirmed = true
                    };

                    var result = await userManager.CreateAsync(newAdmin, adminPassword);
                    if (result.Succeeded)
                        await userManager.AddToRoleAsync(newAdmin, "Admin");
                }
            }
        }
    }
}
