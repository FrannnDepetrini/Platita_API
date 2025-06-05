using Application.Interfaces;
using Application.Models.Responses;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService(IUserRepository userRepository, IClientRepository clientRepository) : IUserService
    {

        private readonly IUserRepository _userRepository = userRepository;
        private readonly IClientRepository _clientRepository = clientRepository;


       

        public async Task<object> GetUser(int userId, string userRole)
        {
            var user = userRole == RolesEnum.Client.ToString() 
                ? await _clientRepository.GetById(userId) 
                : await _userRepository.GetById(userId);

            if (user == null)
                throw new Exception("Invalid User");

            if (userRole == RolesEnum.Client.ToString())
            {
                return ClientDTO.Create((Client)user);
            }

            return UserDTO.Create(user);
        }


    }
}
