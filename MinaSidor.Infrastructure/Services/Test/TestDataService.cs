using Bogus;
using MinaSidor.Core.Dtos.Auth;
using MinaSidor.Core.Models;
using MinaSidor.Core.Policy;
using MinaSidor.Core.Services.Auth;
using MinaSidor.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace MinaSidor.Infrastructure.Services.Test;

/// <summary>
/// Service that creates test data. 
/// <b>Should not be used in the production!</b>
/// </summary>
public class TestDataService
{
    private readonly IAuthService _authService;
    private readonly ApplicationDbContext _dbContext;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ILogger<TestDataService> _logger;

    /// <summary>
    /// Password that is assigned to all test users(but not for fake users).
    /// </summary>
    public const string DefaultPassword = "Password1!";
    /// <summary>
    /// Seed for all fake data generations.
    /// </summary>
    public const int FakeDataGeneratorSeed = 70222500;

    public TestDataService(IAuthService authService, ApplicationDbContext dbContext,
        UserManager<ApplicationUser> userManager, ILogger<TestDataService> logger)
    {
        _authService = authService;
        _dbContext = dbContext;
        _userManager = userManager;
        _logger = logger;
        Randomizer.Seed = new(FakeDataGeneratorSeed);
    }

    /// <summary>
    /// Creates one test Agent and one test OfficeAdmin.
    /// </summary>
    public async Task CreateTestUsersAsync()
    {
        const string AgentUserName = "Agent";
        const string OfficeAdminUserName = "OfficeAdmin";
        RegisterDto AgentRegisterDto = new("test-Agent@e-university.com", "Jesse", "Pinkman", "Bruce");
        RegisterDto OfficeAdminRegisterDto = new("test-OfficeAdmin@e-university.com", "Walter", "White", "Hartwell");

        await _authService.RegisterAsync(AgentRegisterDto,
            AgentUserName, DefaultPassword, Roles.Agent);

        await _authService.RegisterAsync(OfficeAdminRegisterDto,
            OfficeAdminUserName, DefaultPassword, Roles.OfficeAdmin);
    }

    /// <summary>
    /// Creates many fake OfficeAdmins and Agents.
    /// </summary>
    /// <param name="OfficeAdmins">Number of OfficeAdmins to be created.</param>
    /// <param name="Agents">Number of studetns to be created.</param>
    public async Task CreateFakeUsersAsync(int OfficeAdmins = 50, int Agents = 200)
    {
        // Do not generate users if there are enough of them already
        int usersCount = await _dbContext.Users.CountAsync();
        if (usersCount >= OfficeAdmins + Agents)
        {
            _logger.LogInformation("Users generation was skipped: There are {usersCount} users already", usersCount);
            return;
        }

        _logger.LogInformation("Users generation has been started");

        static RegisterDto GenerateUser(Faker faker)
        {
            string firstName = faker.Name.FirstName();
            string lastName = faker.Name.LastName();
            string email = faker.Internet.Email(firstName, lastName);
            // Add middle name with 15% probabilty:
            string? middleName = faker.Random.Bool(0.15f) ?
                faker.Name.FirstName() : null;

            return new(email, firstName, lastName, middleName);
        }

        Randomizer.Seed = new(FakeDataGeneratorSeed);
        var usersFaker = new Faker<RegisterDto>()
            .CustomInstantiator(GenerateUser);

        // Register OfficeAdmins
        _logger.LogInformation("Generating {OfficeAdmins} OfficeAdmins", OfficeAdmins);
         _authService.RegisterManyAsync(usersFaker.GenerateLazy(OfficeAdmins), Roles.OfficeAdmin);
                    // Register Agents
        _logger.LogInformation("Generating {Agents} Agents", Agents);
         _authService.RegisterManyAsync(usersFaker.GenerateLazy(Agents), Roles.Agent);
          

        _logger.LogInformation("Users generation has been finished");
    }

    private async Task CreateFakeEntitiesAsync<T>(Faker<T> faker, int count, bool skipable = true)
        where T : class
    {
        string typeName = typeof(T).Name;

        if (skipable)
        {
            // Do not generate entities if there are enough of them already
            int entitiesCount = await _dbContext.Set<T>().CountAsync();
            if (entitiesCount >= count)
            {
                _logger.LogInformation("Generation of '{typeName}' entities was skipped:" +
                    " There are {entitiesCount} entities of this type already",
                    typeName, entitiesCount);
                return;
            }
        }

        _dbContext.AddRange(faker.GenerateLazy(count));
        await _dbContext.SaveChangesAsync();

        _logger.LogInformation("{count} entities of type '{typeName}' have been generated",
            count, typeName);
    }



}
