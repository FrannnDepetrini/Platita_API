using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.Models.Responses;
using Web.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService ;

        public ReportController(IReportService reportService)
        {
            _reportService = reportService;
        }



        [HttpGet("[action]")]
        [Authorize(Policy = "ModeratorPolicy")]
        public async Task<ActionResult<List<JobReportSummaryDTO>>> GetAllReportedJobs()
        {
            try 
            {
                var jobs = await _reportService.GetJobReportSummariesAsync();
                return Ok(jobs);
            } 
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }        
        }

        [HttpDelete("[action]")]
        [Authorize(Policy = "ModeratorPolicy")]
        public async Task<IActionResult> DeleteJobReported(int jobId)
        {
            try
            {
                 await _reportService.DeleteReportedJob(jobId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        [HttpDelete("[action]")]
        [Authorize(Policy = "ModeratorPolicy")]
        public async Task<IActionResult> CleanJobReported(int jobId)
        {
            try
            {
                 await _reportService.CleanReportedJob(jobId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("[action]")]
        [Authorize(Policy = "ClientPolicy")]
        [AllowAnonymous]
        public async Task<IActionResult> AddReport(int jobId, string category)
        {
            try
            {
                await _reportService.AddReport(User.GetUserIntId(), jobId, category);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
