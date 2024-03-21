using Duende.IdentityServer.EntityFramework.Options;
using MinaSidor.Core.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace MinaSidor.Infrastructure.Data;

public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
{


    public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions)
        : base(options, operationalStoreOptions)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        if (!optionsBuilder.IsConfigured)
            {
            optionsBuilder.UseSqlServer("Data Source=10.224.126.126;Initial Catalog=newsitetest;User ID=sa;Password=RFwo$1e%1o;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=True");
            }
        }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //// ApplicationUser(Agent)->Groups
        //builder.Entity<ApplicationUser>()
        //    .HasMany<Group>()
        //    .WithMany(g => g.Agents)
        //    .UsingEntity<AgentGroup>();

        //// ApplicationUser(Agent)->Semesters
        //builder.Entity<ApplicationUser>()
        //    .HasMany<Semester>()
        //    .WithMany(s => s.Agents)
        //    .UsingEntity<AgentSemester>();
    }
}