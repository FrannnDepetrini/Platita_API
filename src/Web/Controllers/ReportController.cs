using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
using Application.Models.Responses;

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


    }
}
