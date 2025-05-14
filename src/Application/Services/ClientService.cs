using Application.Interfaces;
using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

public class ClientService(IClientRepository clientRepository) : IClientService
{
    private readonly IClientRepository _clientRepository = clientRepository;
    public async Task<ClientDTO> UpdateClient(UpdateClientRequest request, int clientId)
    {
        var clientToUpdate = await _clientRepository.GetById(clientId);
        if (clientToUpdate == null)
        {
            throw new Exception("user not found");
        }
        clientToUpdate.UserName = request.UserName;
        clientToUpdate.PhoneNumber = request.PhoneNumber;

        var updatedClient = await _clientRepository.Update(clientToUpdate);
        var clientDto = ClientDTO.Create(updatedClient);
        return clientDto;
    }
}
