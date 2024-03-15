using MinaSidor.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace MinaSidor.Extensions;

public static class WebApplicationBuilderExtensions
{
    public static void ConnectDatabase(this WebApplicationBuilder builder)
    {
        using var loggerFactory = LoggerFactory.Create(loggingBuilder => loggingBuilder
                    .SetMinimumLevel(LogLevel.Trace)
                    .AddConsole());
        var logger = loggerFactory.CreateLogger<Program>();

        var useInMemoryDb = Environment.GetEnvironmentVariable("USE_IN_MEMORY_DATABASE");
        Action<DbContextOptionsBuilder> dbContextOptions;
        if (useInMemoryDb == null || useInMemoryDb == "false")
        {
            // Use SQL Server
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            dbContextOptions = o => o.UseSqlServer(connectionString, b => b.MigrationsAssembly("MinaSidor.Infrastructure"));
        }
       

    }
}
