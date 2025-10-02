using Application.Models.Responses;
using Domain.Entities;

namespace Application.Interfaces;

    public interface IUserService
    {
        Task<object> GetUser(int userId, string userRole);
        Task<ClientProfileDTO> GetUserById(int userId);
    }
