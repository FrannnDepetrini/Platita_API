using Application.Interfaces;
using Application.Model.Requests;
using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity.Data;
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
        public async Task<IActionResult> Login(LoginRequest user)
        {
            
            var token = await _authService.Login(user.Email, user.Password);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register([FromBody]RegisterRequest user)
        {
            
            var result = await _authService.Register(User, user.Email, user.Password, user.Role, user.UserName, user.PhoneNumber);
            if (!result)
            {
                return BadRequest("User already exists");
            }    
            return Ok("Usuario registrado");
            
        }
    }
}
