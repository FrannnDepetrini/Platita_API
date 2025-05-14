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
    public async Task<ActionResult<ClientDTO>> Update([FromBody] UpdateClientRequest request)
    {
        try
        {
            var userId = User.GetUserIntId();
            await _clientService.UpdateClient(request, userId);
            return Ok(request);
        }
        catch (System.Exception)
        {
            return NotFound();
        }
    }

}