using Application.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService(IUserRepository userRepository) : IUserService
    {

        private readonly IUserRepository _userRepository = userRepository;


       

        public async Task UpdateUser(string? email, string? username, int? phoneNumber, int userId)
        {
            throw new NotImplementedException();
        }

        
        
    }
}
