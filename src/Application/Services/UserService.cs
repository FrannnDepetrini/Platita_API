using Application.Interfaces;
using Domain.Interfaces;
using Application.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models.Responses;

namespace Application.Services
{
    public class UserService(IUserRepository userRepository) : IUserService
    {

        private readonly IUserRepository _userRepository = userRepository;



        // public async Task<UserDto> UpdateUser()
        // {
        //     var userToUpdate = await _userRepository.GetById(userId);
        //     if (userToUpdate == null)
        //     {
        //         throw new Exception("user not found");
        //     }
        //     userToUpdate.Email = request.Email;
        //     userToUpdate.UserName = request.UserName;
        //     userToUpdate.PhoneNumber = request.PhoneNumber;

        //     var updatedUser = await _userRepository.Update(userToUpdate);
        //     var userDto = UserDto.Create(updatedUser);
        //     return userDto;
        // }


    }
}
