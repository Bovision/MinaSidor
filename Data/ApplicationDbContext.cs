using Core.Models;
using Core.Models.User;
using Core.Models.UserModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                Id = RoleaUser,
                Name = "User",
                NormalizedName = "User"

                });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
                {
                Id = Roleadmin,
                Name = "Administrator",
                NormalizedName = "Administrator"

                });

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
                {

                Id = userid,
                Email = "admin@bovision.se",
                NormalizedEmail = "admin@bovision.se",
                UserName = "admin@bovision.se",
                NormalizedUserName = "admin@bovision.se",
                PasswordHash = hasher.HashPassword(null, "bovision"),


                });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
                {
                RoleId = Roleadmin,
                UserId = userid

                });
            base.OnModelCreating(modelBuilder);
            }
        PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

        string Roleadmin = Guid.NewGuid().ToString();
        string RoleaUser = Guid.NewGuid().ToString();
        string userid = Guid.NewGuid().ToString();
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Agent> Agents { get; set; }
        public DbSet<Officeaffiliation> OfficeAffiliations { get; set; }
        public DbSet<Estate> Estates { get; set; }
        }

    }
