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
//[Authorize]
public class JobController : ControllerBase
{
    private readonly IJobService _jobService;

    public JobController(IJobService jobService)
    {
        _jobService = jobService;
    }

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        try
        {
            await _jobService.Delete(id, User.GetUserIntId());
            return Ok();
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpDelete("deleteLogic/{id}")]
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

    [HttpPut("update/{id}")]
    public async Task<ActionResult<JobDTO>> Update([FromBody] JobUpdateRequest request, [FromRoute] int id)
    {
        try
        {
            await _jobService.Update(request, id, User.GetUserIntId());
            return Ok();
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

    [HttpPost("create")]
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

    [HttpGet("by-location")]
    public async Task<ActionResult<List<JobDTO>>> GetJobsByLocation()
    {
        var userId = User.GetUserIntId();
        var jobs = await _jobService.GetJobsByClientLocationAsync(userId);
        return Ok(jobs);
    }

    [HttpPost("[action]")]
    public async Task<ActionResult<List<JobDTO>>> GetJobForSearch(string Province, string city)
    {
        var jobs = await _jobService.GetJobsBySearchLocationAsync(Province, city);
        return Ok(jobs);
    }

    [HttpGet("my-jobs")]
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

    [HttpPost("FilteredForCategory")]
    public async Task<ActionResult<IEnumerable<JobDTO>>> GetJobByCategory([FromBody] JobFilteredByCategoryRequest request)
    {
        try
        {
            var jobs = await _jobService.GetJobsByCategory(request);
            return Ok(jobs);

        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }
}





