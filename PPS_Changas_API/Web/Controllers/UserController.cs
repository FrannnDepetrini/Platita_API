using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) 
        {
            _userService = userService;
        }


        [HttpPost]
        public async Task<IActionResult>ChangePassword(string oldPassword, string newPassword)
        {
            var userId = User.GetUserIntId();

            await _userService.ChangePasswordAsync(userId, oldPassword, newPassword);

            return Ok();
        }
    }
}
