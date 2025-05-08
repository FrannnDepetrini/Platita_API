using Application.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService(IUserRepository userRepository, IPasswordHasher passwordHasher) : IUserService
    {

        private readonly IUserRepository _userRepository = userRepository;
        private readonly IPasswordHasher _passwordHasher = passwordHasher;


        public Task ResetPassword(string token, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task SendResetPasswordEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUser(string? email, string? username, int? phoneNumber, int userId)
        {
            throw new NotImplementedException();
        }

        public async Task ChangePasswordAsync(int userId, string password, string newPassword)
        {
            var user = await _userRepository.GetById(userId);
            if (user == null)
                throw new Exception("Invalid user");

            var isCurrentPasswordValid = _passwordHasher.VerifyPassword(password, user.Password);
            if (!isCurrentPasswordValid)
                throw new Exception("Wrong password");

            user.Password = _passwordHasher.HashPassword(newPassword);
            await userRepository.Update(user);
        }
    }
}
