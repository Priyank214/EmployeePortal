using EmployeePortal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal.Data
{
    public class AppDbContext : IdentityDbContext<Users>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Contactus> Contactus { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var hasher = new PasswordHasher<Users>();
            var hashedPassword = hasher.HashPassword(null, "admin$123");

            builder.Entity<Users>().HasData(
                new Users
                {
                    Id = Guid.NewGuid().ToString(),
                    FullName = "Admin Digiwhiz",
                    UserName = "Admin",
                    NormalizedUserName = "admin.digiwhiz@gmail.com",
                    Email = "admin.digiwhiz@gmail.com",
                    NormalizedEmail = "admin.digiwhiz@gmail.com",
                    EmailConfirmed = false,
                    PasswordHash = hashedPassword,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "+938434444445",
                    PhoneNumberConfirmed = true,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = false,
                    AccessFailedCount = 0
                }
            );

            builder.Entity<Employee>().HasData(
                new Employee {  Id = Guid.NewGuid().ToString(), FirstName= "Unish" , LastName="Kumar",Email= "unish.kumar@digiwhiz.com.au" },
                new Employee { Id = Guid.NewGuid().ToString(), FirstName = "Harikrishna", LastName = "Parmar", Email = "hariparmar@digiwhiz.com.au" },
                new Employee { Id = Guid.NewGuid().ToString(), FirstName = "Jigar", LastName = "Gor", Email = "jigar.gor@digiwhiz.com.au" },
                new Employee { Id = Guid.NewGuid().ToString(), FirstName = "Vikash", LastName = "Shah", Email = "vikash.shah@digiwhiz.com.au" },
                new Employee { Id = Guid.NewGuid().ToString(), FirstName = "Charmi", LastName = "Shah", Email = "charmi.shah@digiwhiz.com.au" },
                new Employee { Id = Guid.NewGuid().ToString(), FirstName = "Peter", LastName = "Parker", Email = "peter.parker@digiwhiz.com.au" }

                );
        }
    }
}
