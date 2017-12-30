using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace BadaHub.API.Infra.Identity.Authorization
{
    public class ClaimsRequirementHandler : AuthorizationHandler<ClaimsRequirement>
    {

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                       ClaimsRequirement requirement)
        {

            var claim = context.User.Claims.FirstOrDefault(c => c.Type == requirement.ClaimName);
            if (claim != null && claim.Value.Contains(requirement.ClaimValue))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
