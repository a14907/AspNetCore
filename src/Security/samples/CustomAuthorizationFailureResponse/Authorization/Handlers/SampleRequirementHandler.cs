using System.Threading.Tasks;
using CustomAuthorizationFailureResponse.Authorization.Requirements;
using Microsoft.AspNetCore.Authorization;

namespace CustomAuthorizationFailureResponse.Authorization.Handlers
{
    public class SampleRequirementHandler : AuthorizationHandler<SampleRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, SampleRequirement requirement)
        {
            // assuming the requirement was not met
            return Task.CompletedTask;
        }
    }
}
