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

        public PostulationController(IPostulationService postulationService)
        {
            _postulationService = postulationService;
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

        [HttpPost("[action]")]

        public async Task<IActionResult> CreateAsync(PostulationRequest request)
        {
            try
            {
                int userId = User.GetUserIntId();
                var result = await _postulationService.PostulateAsync(userId, request.JobId, request.Budget);
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
    }
}
