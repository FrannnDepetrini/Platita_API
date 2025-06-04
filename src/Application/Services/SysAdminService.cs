using Application.Interfaces;
using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Constants;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SysAdminService : ISysAdminService
    {
        private readonly IUserRepository _userRepository;
        private readonly ISysAdminRepository _sysAdminRepository;
        public SysAdminService(IUserRepository userRepository, ISysAdminRepository sysAdminRepository)
        {
            _userRepository = userRepository;
            _sysAdminRepository = sysAdminRepository;
        }

        public async Task DeleteUser(int id)
        {
            var user = await _userRepository.GetById(id);
            await _userRepository.Delete(user);
        }

        public async Task<List<UserDTO>> GetAllUsers(int userId)
        {
            var users = await _sysAdminRepository.GetAllUsers(userId);
            return users.Select(UserDTO.Create).ToList();
        }

        public async Task<List<UserDTO>> GetAllUsersByRole(int userId ,string role)
        {
            var users = await _sysAdminRepository.GetAllUsersByRole(userId, Enum.Parse<RolesEnum>(role));
            return users.Select(UserDTO.Create).ToList();
        }
        public async Task<UserDTO> GetUserById(int id)
        {
            var user = await _userRepository.GetById(id);
            if (user == null)
            {
                throw new Exception("User not found");
            }
            
            var userDTO = UserDTO.Create(user);
            return userDTO;

        }

        public async Task<UserDTO> UpdateUser(int id, UpdateUserRequest request)
        {
            var user = await _userRepository.GetById(id);
            if ( user == null)
            {
                throw new Exception("User not found");
            }

            user.UserName = request.UserName ?? user.UserName;
            user.PhoneNumber = request.PhoneNumber ?? user.PhoneNumber;

            var updatedUser = await _userRepository.Update(user);
            var userDTO = UserDTO.Create(updatedUser);
            return userDTO;

        }
    }
}
