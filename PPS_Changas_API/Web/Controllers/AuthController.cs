using Application.Interfaces;
using Application.Models.Requests;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity.Data;

using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Web.Extensions;

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
            var token = await _authService.Login(user);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordRequest request)
        {
            await _authService.ForgotPasswordAsync(request.Email);
            return Ok("Si el correo está registrado, se envió un enlace para restablecer la contraseña.");
        }


        [HttpPost("[action]")]

        public async Task<IActionResult> Register([FromBody] RegisterRequest user)
        {

            var result = await _authService.Register(user);

            if (!result)
            {
                return BadRequest("User already exists");
            }

            return Ok("Usuario registrado");
        }


        [HttpPost("[action]/sysAdmin")]
        [Authorize(Policy = "SysAdminPolicy")]
        public async Task<IActionResult> RegisterForSysAdmin([FromBody] RegisterForSysAdminRequest user)
        {
            var result = await _authService.RegisterForSysAdmin(user);

            if (!result)
            {
                return BadRequest("User already exists");
            }

            return Ok("Usuario registrado");
        }


        [HttpPost("change-password")]
        [Authorize]
        public async Task<IActionResult> ChangePassword(ChangePasswordRequest request)
        {
            var userId = User.GetUserIntId();

            await _authService.ChangePasswordAsync(userId, request);

            return Ok();
        }



        [HttpPut("reset-password")]
        public async Task<IActionResult> ResetForgottenPassword(ResetForgottenPasswordRequest request)
        {
            await _authService.ResetForgottenPassword(request);
            return Ok();
        }
    }
}
