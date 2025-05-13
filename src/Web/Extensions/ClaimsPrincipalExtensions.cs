using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Web.Extensions
{
    internal static class ClaimsPrincipalExtensions
    {
        public static int GetUserIntId(this ClaimsPrincipal user)
        {
            //var userId = user.FindFirst("id")?.Value;

            var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value
              ?? user.FindFirst(JwtRegisteredClaimNames.Sub)?.Value;

            if (!int.TryParse(userId, out int intId))
            {
                throw new UnauthorizedAccessException("Invalid user ID");
            }

            return intId;
        }
    }
}
