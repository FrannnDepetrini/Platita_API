using Application.Interfaces;
using Application.Models.Requests;
using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost ("[action]")]
        public async Task<IActionResult> Login(LoginRequest user)
        {
            
            var token = await _authService.Login(user.Email, user.Password);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }

        //[HttpPost("[action]")]
        //public async Task<IActionResult> Register([FromBody]RegisterRequest user)
        //{

        //    var result = await _authService.Register(User, user.Email, user.Password, user.Role, user.UserName, user.PhoneNumber);
        //    if (!result)
        //    {
        //        return BadRequest("User already exists");
        //    }    
        //    return Ok("Usuario registrado");

        //}

        [HttpPost("[action]")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest user)
        {
            var creatorRole = User.FindFirst(ClaimTypes.Role)?.Value;

            var result = await _authService.Register(
                creatorRole,
                user.Email,
                user.Password,
                user.Role,
                user.UserName,
                user.PhoneNumber
            );

            if (!result)
            {
                return BadRequest("User already exists");
            }

            return Ok("Usuario registrado");
        }
    }
}
