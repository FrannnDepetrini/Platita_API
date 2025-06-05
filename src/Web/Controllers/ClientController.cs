using Application.Interfaces;
using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;

namespace Web.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Policy = "ClientPolicy")]


public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpPut("[action]")]
    public async Task<ActionResult> UpdateClient([FromBody] UpdateClientRequest request)
    {
        try
        {
            await _clientService.UpdateClient(request, User.GetUserIntId());
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("[action]")]
    public async Task<IActionResult> AutoDeleteClient()
    {
        await _clientService.AutoDeleteClient(User.GetUserIntId());
        return Ok();
    }

}