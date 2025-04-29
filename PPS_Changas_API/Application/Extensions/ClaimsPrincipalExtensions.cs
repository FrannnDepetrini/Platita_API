using System.Security.Claims;

namespace Application.Extensions
{
    internal static class ClaimsPrincipalExtensions
    {
        public static int GetUserIntId(this ClaimsPrincipal user)
        {
            var userId = user.FindFirst("id")?.Value;

            if (!int.TryParse(userId, out int intId))
            {
                throw new UnauthorizedAccessException("Invalid user ID");
            }

            return intId;
        }
    }
}
