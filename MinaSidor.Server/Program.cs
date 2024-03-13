using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MinaSidor.Server.Areas.Identity.Data;
using MinaSidor.Server.Data;
using System.Data.Common;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("MinaSidorServerContextConnection") ?? throw new InvalidOperationException("Connection string 'MinaSidorServerContextConnection' not found.");
DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
builder.Services.AddDbContext<MinaSidorServerContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<BovisionUser>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>().AddEntityFrameworkStores<MinaSidorServerContext>();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Default Password settings.
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 1;
    options.Password.RequiredUniqueChars = 0;
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication(); ;
app.MapRazorPages();
app.UseAuthorization();
app.MapControllerRoute(
    name: "Role",
    pattern: "{controller=Role}/{action=Index}/{id?}");

app.MapFallbackToFile("/index.html");

app.Run();
