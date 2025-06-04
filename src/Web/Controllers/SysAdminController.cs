using Application.Interfaces;
using Application.Models.Requests;
using Application.Models.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Policy = "SysAdminPolicy")]
    public class SysAdminController : ControllerBase
    {
        private readonly ISysAdminService _sysAdminService;
        public SysAdminController(ISysAdminService sysAdminService)
        {
            _sysAdminService = sysAdminService;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUsers()
        {
            var userId = User.GetUserIntId();

            var users = await _sysAdminService.GetAllUsers(userId);
            return Ok(users);
        }


        [HttpGet("[action]")]
        public async Task<ActionResult<UserDTO>> GetUserById(int id)
        {
            if (id == User.GetUserIntId())
            {
                var message = "Can't get yourself";
                return StatusCode(403, message);
            }

            try
            {
                var user = await _sysAdminService.GetUserById(id);
                return Ok(user);

            }
            catch (Exception)
            {
                return NotFound();
            }
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (id == User.GetUserIntId())
            {
                var message = "Can't self delete";
                return StatusCode(403, message);
            }
            try
            {
                await _sysAdminService.DeleteUser(id);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpPut("[action]")]
        public async Task<IActionResult>UpdateUser(int id, [FromBody]UpdateUserRequest request)
        {
            try
            {
                await _sysAdminService.UpdateUser(id,request);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsersByRole(string role)
        {
            var userId = User.GetUserIntId();

            var users = await _sysAdminService.GetAllUsersByRole(userId, role);
            return Ok(users);
        }

        



    }
}
