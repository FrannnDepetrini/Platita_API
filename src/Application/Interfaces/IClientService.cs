namespace Application.Interfaces;
using Application.Models.Requests;
using Application.Models.Responses;

public interface IClientService
    {
        Task<ClientDto>UpdateClient(UpdateClientRequest request, int clientId);

    }
