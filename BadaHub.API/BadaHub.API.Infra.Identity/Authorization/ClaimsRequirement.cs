using Microsoft.AspNetCore.Authorization;

namespace BadaHub.API.Infra.Identity.Authorization
{
    public class ClaimsRequirement : IAuthorizationRequirement
    {
        public ClaimsRequirement(string claimName, string claimValue)
        {
            ClaimName = claimName;
            ClaimValue = claimValue;
        }

        public string ClaimName { get; set; }
        public string ClaimValue { get; set; }
    }
}
