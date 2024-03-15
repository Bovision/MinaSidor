using Duende.IdentityServer.Extensions;
using MinaSidor.Server.Controllers;
using IdentityModel;
using Microsoft.AspNetCore.Authorization;
using MinaSidor.Controllers;

namespace MinaSidor.Auth;

/// <summary>
/// Authorization handler that allows Agents access only their own data.
/// <see cref="AccessOnlyOwnDataAuthorizationRequirement" /> can contain roles
/// that are allowed to access any data.
/// </summary>
/// <remarks>
/// This handler checks route parameter 'AgentId'.
/// </remarks>
public class AccessOnlyOwnDataAuthorizationHandler :
    AuthorizationHandler<AccessOnlyOwnDataAuthorizationRequirement>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AccessOnlyOwnDataAuthorizationRequirement requirement)
    {
        if (!context.User.IsAuthenticated())
        {
            context.Fail();
            return Task.CompletedTask;
        }
        // Check if we can skip the check
        if (requirement.SkipRoles.Any(r => context.User.HasClaim(JwtClaimTypes.Role, r)))
        {
            context.Succeed(requirement);
            return Task.CompletedTask;
        }

        // Get an ID from route values
        if (context.Resource is not HttpContext httpContext)
        {
            throw new InvalidOperationException("Cannot access HTTP context");
        }
        object? routeId = httpContext.GetRouteValue(UsersController.AgentIdRouteKey) ??
            throw new InvalidOperationException($"Cannot get route value of '{UsersController.AgentIdRouteKey}'");
        // Each user can view his/her enrollments
        if (context.User.GetSubjectId() == routeId.ToString())
        {
            context.Succeed(requirement);
            return Task.CompletedTask;
        }

        context.Fail();
        return Task.CompletedTask;
    }
}
