using Application.Models.Requests;
using Application.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ISysAdminService
    {
        Task<List<UserDTO>> GetAllUsers(int userId);
        Task<List<UserDTO>> GetAllUsersByRole(int userId, string role);

        Task<UserDTO> GetUserById(int id);  
        Task DeleteUser(int id);
        Task<UserDTO> UpdateUser(int id, UpdateUserRequest request);
    }
}
