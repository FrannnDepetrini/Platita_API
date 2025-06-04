using Application.Interfaces;
using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Extensions;

namespace Web.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ClientController : ControllerBase
{
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpPut("updateUser")]
    public async Task<ActionResult> Update([FromBody] UpdateClientRequest request)
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

}