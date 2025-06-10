using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Application.Interfaces;
using Application.Models.Requests;
using Microsoft.AspNetCore.Http.HttpResults;
using Web.Extensions;
using Microsoft.AspNetCore.Authorization;
using Application.Models.Responses;
using Application.Models;
using Domain.Constants;
using Application.Services;
using Domain.Entities;

namespace Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JobController : ControllerBase
{
    private readonly IJobService _jobService;

    public JobController(IJobService jobService)
    {
        _jobService = jobService;
    }


    [HttpGet("by-location")]
    [Authorize(Policy ="ClientPolicy")]
    public async Task<ActionResult<List<JobDTO>>> GetJobsByLocation()
    {
        var jobs = await _jobService.GetJobsByClientLocationAsync(User.GetUserIntId());
        return Ok(jobs);
    }

    [HttpGet("[action]")]
    [Authorize(Policy = "ClientPolicy")]
    public async Task<ActionResult<List<JobDTO>>> GetJobForSearch(string Province, string city)
    {
        var jobs = await _jobService.GetJobsBySearchLocationAsync(Province, city, User.GetUserIntId());
        return Ok(jobs);
    }

    [HttpGet("[action]")]
    [Authorize(Policy = "ClientPolicy")]
    public async Task<ActionResult<IEnumerable<JobDTO>>> GetJobByCategory([FromQuery] JobFilteredByCategoryRequest request)
    {
        try
        {
            var jobs = await _jobService.GetJobsByCategory(request, User.GetUserIntId());
            return Ok(jobs);

        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpGet("my-jobs")]
    [Authorize(Policy = "ClientPolicy")]
    public async Task<ActionResult<List<JobDTO>>> GetMyJobs()
    {
        var userId = User.GetUserIntId();
        var jobs = await _jobService.GetJobsByClientAsync(userId);
        if (jobs == null || !jobs.Any())
        {
            return NotFound("No se encontraron trabajos para este cliente.");
        }
        return Ok(jobs);
    }
    
    [HttpGet("[action]")]
    [Authorize(Policy = "ModeratorPolicy")]
    public async Task<ActionResult<List<AllJobsDTO>>> GetAllJobsForModerator()
    {
        var jobs = await _jobService.GetAllJobs();
        return Ok(jobs);
    }

    [HttpGet("[action]")]
    [Authorize(Policy = "ModeratorPolicy")]
    public async Task<ActionResult<List<JobDtoReport>>> GetAllJobsReportedForModerator()
    {
        var jobs = await _jobService.GetAllJobsReported();
        return Ok(jobs);
    }

    [HttpGet("[action]")]
    [Authorize(Policy = "ClientPolicy")]
    public async Task<ActionResult<JobDTO>> GetJobById(int jobId)
    {
        try
        {
            return Ok(await _jobService.GetJobById(jobId, User.GetUserIntId()));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    [HttpPost("create")]
    [Authorize(Policy = "ClientPolicy")]
    public async Task<ActionResult<JobDTO>> Create([FromBody] JobRequest request)
    {
        try
        {
            var job = await _jobService.Create(request, User.GetUserIntId());
            return Ok(job);
        }
        catch (Exception ex)
        {
            var innerMessage = ex.InnerException?.Message ?? ex.Message;
            return BadRequest(new { error = innerMessage });
        }
    }

    [HttpPut("update/{id}")]
    [Authorize(Policy = "ClientPolicy")]
    public async Task<ActionResult<JobDTO>> Update([FromBody] JobUpdateRequest request, [FromRoute] int id)
    {
        try
        {
            await _jobService.Update(request, id, User.GetUserIntId());
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("[action]")]
    [Authorize(Policy = "ClientPolicy")]
    public async Task<IActionResult> JobFinished(int idJob)
    {
        try
        {
            await _jobService.JobFinished(idJob, User.GetUserIntId());
            return Ok();
        }
        catch(Exception ex) 
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("delete/{id}")]
    [Authorize(Policy = "SysAdminOrModeratorPolicy")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        try
        {
            await _jobService.Delete(id, User.GetUserIntId());
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPatch("[action]")]
    [Authorize(Policy = "ClientPolicy")]
    public async Task<IActionResult> DeleteLogic([FromRoute] int id)
    {
        try
        {
            await _jobService.DeleteLogic(id, User.GetUserIntId());
            return Ok();
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    
    [HttpPatch("[action]")]
    [Authorize(Policy = "ClientPolicy")]
    public async Task<IActionResult> ResetJobCancellation(int idJob)
    {
        try
        {
            await _jobService.ResetJobCancellation(idJob, User.GetUserIntId());
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}





