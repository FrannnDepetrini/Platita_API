using Application.Interfaces;
using Application.Models.Requests;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) 
        {
            _userService = userService;
        }


        [HttpPost("change-password")]
        public async Task<IActionResult>ChangePassword(string oldPassword, string newPassword)
        {
            var userId = User.GetUserIntId();

            await _userService.ChangePasswordAsync(userId, oldPassword, newPassword);

            return Ok();
        }

        [AllowAnonymous]
        [HttpPut("reset-password")]
        public async Task<IActionResult> ResetForgottenPassword(ResetPasswordRequest request)
        {
            await _userService.ResetForgottenPassword(request.Token, request.NewPassword);
            return Ok();
        }
    }
}
