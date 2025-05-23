using Application.Interfaces;
using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Constants;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Web.Extensions;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostulationController : ControllerBase
    {

        private readonly IPostulationService _postulationService;
        private readonly IUserService _userService;

        public PostulationController(IPostulationService postulationService,IUserService userService )
        {
            _postulationService = postulationService;
            _userService = userService;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetPostulationsByJobId(int jobId)
        {
            try
            {
                int publisherId = User.GetUserIntId();

                var postulations = await _postulationService.GetPostulationsByJobIdAsync(jobId, publisherId);
                return Ok(postulations);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        public async Task<ActionResult> GetMyPostulations()
        {
            try
            {
                var userId = User.GetUserIntId();
                var MyPostulations = await _postulationService.GetMyPostulations(userId);
                return Ok(MyPostulations);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("[action]")]

        public async Task<IActionResult> ApplicateJob(PostulationRequest request)
        {
            try
            {
                int userId = User.GetUserIntId();
                var result = await _postulationService.PostulateAsync(userId, request.JobId, request.Budget, request.jobDay);
                return Ok(result);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Forbid(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("[action]")]
        public async Task<IActionResult> ApproveApplication(int jobId, int postulantId)
        {
            try
            {
                int userId = User.GetUserIntId();
                var result = await _postulationService.ChangeStatusPostulation(jobId, postulantId, userId);

                return Ok(result);
            }
            catch (UnauthorizedAccessException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        

        [HttpDelete("[action]")]
        public async Task<ActionResult> DeletePostulationFisic(int jobId, int postulationId)
        {
            try
            {
                var postulation = await _postulationService.DeletePostulationFisic(jobId, postulationId);
                return Ok();


            }
            catch (UnauthorizedAccessException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("[action]")]
        public async Task<ActionResult> DeletePostulationLogic(int jobId, int postulationId)
        {
            try
            {
                var postulation = await _postulationService.DeletePostulationLogic(jobId, postulationId);
                return Ok();
            }
            catch (UnauthorizedAccessException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("[action]")]
        public async Task<ActionResult> CancelWhenSuccessPostulation(int jobId, int postulationId)
        {
            try
            {
                 await _postulationService.CancelPostulation(jobId, postulationId, User.GetUserIntId());

                return Ok();
            }
            catch (UnauthorizedAccessException ex)
            {
                return BadRequest(ex.Message);
            }
        }


        
    }
}
