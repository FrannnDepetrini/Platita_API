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
    public class RatingController : ControllerBase
    {

        private readonly IRatingService _ratingService;
        public RatingController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpGet("[action]")]
        [Authorize(Policy = "ClientPolicy")]
        public async Task<IActionResult> GetMyOrOtherReceivedRatingsForEmployer(int clientId = 0)
        {
            try
            {
                var reviews = await _ratingService.GetMyOrOtherReceivedRatingsForEmployer(clientId == 0 ? User.GetUserIntId() : clientId);
                return Ok(reviews);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("[action]")]
        [Authorize(Policy = "ClientPolicy")]
        public async Task<IActionResult> GetMyOrOtherReceivedRatingsForEmployee(int clientId = 0)
        {
            try
            {
                var reviews = await _ratingService.GetMyOrOtherReceivedRatingsForEmployee(clientId == 0 ? User.GetUserIntId() : clientId);
                return Ok(reviews);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("[action]")]
        [Authorize(Policy = "ClientPolicy")]
        public async Task<IActionResult> GetMyReceivedRatingsScore(int clientId = 0)
        {
            try
            {
                var reviews = await _ratingService.GetMyReceivedRatingsScore(clientId == 0 ? User.GetUserIntId() : clientId);
                return Ok(reviews);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("[action]")]
        [Authorize(Policy = "ClientPolicy")]
        public async Task<IActionResult> CreateRating(CreateRatingRequest request)
        {

            try
            {
                await _ratingService.CreateRating(User.GetUserIntId(), request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [HttpDelete("[action]")]
        [Authorize(Policy = "SysAdminPolicy")]
        public async Task<IActionResult> DeleteRatingPhysics(int idRating)
        {
            try
            {
                await _ratingService.DeleteRatingPhysics(idRating);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

    }
}
