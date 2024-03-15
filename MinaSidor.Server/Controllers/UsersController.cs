using Duende.IdentityServer.Extensions;
using MinaSidor.Core.Dtos.Users;
using MinaSidor.Core.Pagination;
using MinaSidor.Core.Policy;
using MinaSidor.Core.Services.Auth;
using MinaSidor.Core.Services.Users;
using MinaSidor.Infrastructure.Filters;
using IdentityModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Attributes;

namespace MinaSidor.Controllers;

[ApiController]
[Route("api/users")]
[FluentValidationAutoValidation]
[Authorize]
public class UsersController : ControllerBase
{
    private readonly IAuthService _authService;
    private readonly IUsersService _usersService;

    public const string AgentIdRouteKey = "AgentId";

    public UsersController(IAuthService authService,
        IUsersService usersService)
    {
        _authService = authService;
        _usersService = usersService;

    }

    [HttpGet]
    [ProducesResponseType(typeof(Page<UserPreviewDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [Authorize(Policies.HasAdministratorPermission)]
    public async Task<IActionResult> GetAllUsersAsync(
        [FromQuery] PaginationProperties paginationProperties,
        [FromQuery] UsersFilterProperties usersFilter)
    {
        return Ok(await _usersService.GetAllUsersAsync(paginationProperties,
            new UsersFilter(usersFilter), false));
    }

    
    [HttpGet("deleted")]
    [ProducesResponseType(typeof(Page<UserPreviewDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [Authorize(Policies.HasAdministratorPermission)]
    public async Task<IActionResult> GetDeletedUsersAsync(
        [FromQuery] PaginationProperties paginationProperties,
        [FromQuery] UsersFilterProperties usersFilter)
    {
        return Ok(await _usersService.GetAllUsersAsync(paginationProperties,
            new UsersFilter(usersFilter), true));
    }

   

    [HttpGet]
    [Route("OfficeAdmins")]
    [ProducesResponseType(typeof(Page<UserPreviewDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    public async Task<IActionResult> GetAllOfficeAdminsAsync(
        [FromQuery] PaginationProperties paginationProperties,
        [FromQuery] UsersFilterProperties usersFilter)
    {
        return Ok(await _usersService.GetUsersInRoleAsync(Roles.OfficeAdmin,
            paginationProperties, new UsersFilter(usersFilter)));
    }

    private async Task<IActionResult> RegisterAsync(RegisterUsersDto Agents, string role, string location)
    {
        List<CreatedUserDto> createdUsers = new();
        await foreach (var result in _authService.RegisterManyAsync(Agents.Users, role))
        {
            CreatedUserDto createdUser = new(
                result.Id,
                result.UserName,
                result.Password,
                result.Succeeded,
                result.Succeeded ? null : result.Errors.Select(e => e.Description)
            );
            createdUsers.Add(createdUser);
        }

        return Created(location, createdUsers);
    }
    [HttpPost]
    [Route("Agents")]
    [ProducesResponseType(typeof(IEnumerable<CreatedUserDto>), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [Authorize(Policies.HasAdministratorPermission)]
    public async Task<IActionResult> RegisterAgentsAsync([FromBody] RegisterUsersDto Agents)
    {
        return await RegisterAsync(Agents, Roles.Agent, "api/users/Agents");
    }


    [HttpGet("{userId}", Name = nameof(GetUserByIdAsync))]
    [Authorize(Policies.Default)]
    [ProducesResponseType(typeof(UserViewDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetUserByIdAsync([FromRoute] string userId)
    {
        UserViewDto? result = await _usersService.GetByIdAsync(userId);
        // User is not found
        if (result == null)
        {
            return NotFound();
        }
        // Check if current user can view a user that is not OfficeAdmin
        if (!result.Roles.Contains(Roles.OfficeAdmin))
        {
            // If current user is not OfficeAdmin or administrator then forbid this action
            if (!User.HasClaim(JwtClaimTypes.Role, Roles.OfficeAdmin) &&
                !User.HasClaim(JwtClaimTypes.Role, Roles.Administrator))
            {
                return Forbid();
            }
        }
        return Ok(result);
    }


    [HttpPut]
    [Route("{userId}")]
    [Authorize(Policies.HasAdministratorPermission)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> EditUserAsync([FromRoute] string userId,
        [FromBody] EditUserDto dto)
    {
        var result = await _usersService.UpdateUserAsync(userId, dto);
        return result ? NoContent() : NotFound();
    }

   
    [HttpPatch]
    [Route("{userId}/roles")]
    [Authorize(Policies.HasAdministratorPermission)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> EditUserRolesAsync([FromRoute] string userId,
        [FromBody] ChangeRolesDto dto)
    {
        var result = await _usersService.UpdateUserRolesAsync(userId, dto);
        return result ? NoContent() : NotFound();
    }

    /// <summary>
    /// Performs a soft delete for a user.
    /// </summary>
    /// <remarks>
    /// Soft delete means, that user will remain in the database but will be unable to sign in
    /// and some GET methods will ignore him/her.
    /// </remarks>
    /// <response code="204">Success</response>
    /// <response code="401">Unauthorized user call</response>
    /// <response code="403">Caller lacks 'Administrator' role</response>
    /// <response code="404">User does not exist</response>
    [HttpDelete]
    [Route("{userId}")]
    [Authorize(Policies.HasAdministratorPermission)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteSemesterAsync([FromRoute] string userId)
    {
        var result = await _usersService.DeleteUserAsync(userId);
        return result ? NoContent() : NotFound();
    }

    
}
