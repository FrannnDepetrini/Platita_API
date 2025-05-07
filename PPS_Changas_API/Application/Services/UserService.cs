using Application.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class UserService(IUserRepository userRepository, IPasswordHasher passwordHasher, ITokenService tokenService) : IUserService
    {

        private readonly IUserRepository _userRepository = userRepository;
        private readonly IPasswordHasher _passwordHasher = passwordHasher;
        private readonly ITokenService _tokenService = tokenService;


        public async Task ResetForgottenPassword(string token, string newPassword)
        {
            var email = _tokenService.GetEmailFromToken(token);

            var user = await _userRepository.GetUserByEmail(email);

            if (user is null)
            {
                throw new Exception("User not found");
            }

            user.Password = _passwordHasher.HashPassword(newPassword);

            await _userRepository.Update(user);
        }

        public async Task SendResetPasswordEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUser(string? email, string? username, int? phoneNumber, int userId)
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
