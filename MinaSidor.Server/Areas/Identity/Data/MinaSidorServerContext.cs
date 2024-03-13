using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MinaSidor.Server.Areas.Identity.Data;

namespace MinaSidor.Server.Data;

public class MinaSidorServerContext : IdentityDbContext<BovisionUser>
{
    public MinaSidorServerContext(DbContextOptions<MinaSidorServerContext> options)
        : base(options)
    {
    }

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

        modelBuilder.Entity<BovisionUser>().HasData(new BovisionUser
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
    PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();

    string Roleadmin = Guid.NewGuid().ToString();
    string RoleaUser = Guid.NewGuid().ToString();
    string userid = Guid.NewGuid().ToString();
    }
