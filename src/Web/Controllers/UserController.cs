using Application.Interfaces;
using Application.Models.Requests;
using Application.Models.Responses;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) 
        {
            _userService = userService;
        }

        // [HttpPut("updateUser")]
        // public async Task<ActionResult<UserDto>> Update([FromBody]UpdateUserRequest request)
        // {
        //     try
        //     {
        //         var userId = User.GetUserIntId();
        //         await _userService.UpdateUser(request, userId);
        //         return Ok(request);
        //     }
        //     catch (System.Exception)
        //     {
        //         return NotFound();
        //     }
        // }

       
    }
}
