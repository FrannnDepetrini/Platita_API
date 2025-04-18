using Application.Interfaces;
using Application.Model.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Login(LoginRequest1 user)
        {
            try
            {
                var token = await _authService.Login(user.Email, user.Password);
                return Ok(token);
            }
            catch (System.Exception)
            {
                return Unauthorized();
            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register([FromBody]RegisterRequest1 user)
        {
            try
            {
                await _authService.Register(User, user.Email, user.Password, user.Role, user.UserName, user.PhoneNumber);
                return Ok("Usuario registrado");
            }
            catch (System.Exception)
            {
                return BadRequest("Usuario existente");
            }
        }
    }
}
