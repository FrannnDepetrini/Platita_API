using Application.Interfaces;
using Application.Models.Requests;
using Application.Services;
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

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateRating(CreateRatingRequest request)
        {

            try
            {
                await _ratingService.CreateRating(User.GetUserIntId(), request);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }


        }

        [HttpDelete("[action]")]
        public async Task<IActionResult> DeleteRatingFisic(int idRating)
        {
            try
            {
                await _ratingService.DeleteRatingFisic(idRating);
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

    }
}
