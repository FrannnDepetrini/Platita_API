using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Application.Interfaces;

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

    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        try
        {
            await _jobService.Delete(id);
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
            await _jobService.DeleteLogic(id);
            return Ok();
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }
}


