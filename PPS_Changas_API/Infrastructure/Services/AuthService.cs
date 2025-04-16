using Application.Interfaces;
using Domain.Constants;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services;

public class AuthService(IUserRepository userRepository, ITokenService tokenService) : IAuthService
{

    private readonly IUserRepository _userRepository = userRepository;
    private readonly ITokenService _tokenService = tokenService;

    public Task<string?> Login(string email, string password)
    {
        var user = "firma del repo que busca al user";
        if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            return null;
        }

        return _tokenService.GenerateToken(user);
    }

    public Task<bool> Register(string email, string password, RolesEnum role, string userName, int phoneNumber)
    {
        var exisitingUser = "firma del repo que busca al user";
        if(exisitingUser is not null)
        {
            return false;
        }

        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
        var newUser = CreateUserByRole(email, hashedPassword, role, userName, phoneNumber);

        // acá va la firma del repo de user que agrega el nuevo usuario a la bd
        return true;
    }

    private User CreateUserByRole(string email, string password, RolesEnum role, string userName, int phoneNumber)
    {
        //if (!Enum.TryParse(role, out RolesEnum userRole))
        //{
        //    throw new ArgumentException("Rol inválido");
        //}

        return role switch
        {
            RolesEnum.SysAdmin => new SysAdmin
            {
                Email = email,
                Password = password,
                Role = role.ToString(),
                UserName = userName,
                PhoneNumber = phoneNumber
            },
            RolesEnum.Moderator => new Moderator
            {
                Email = email,
                Password = password,
                Role = role.ToString(),
                UserName = userName,
                PhoneNumber = phoneNumber
            },
            RolesEnum.Employer => new Employer
            {
                Email = email,
                Password = password,
                Role = role.ToString(),
                UserName = userName,
                PhoneNumber = phoneNumber
            },
            RolesEnum.Employee => new Employee
            {
                Email = email,
                Password = password,
                Role = role.ToString(),
                UserName = userName,
                PhoneNumber = phoneNumber
            },
            _ => throw new ArgumentException("Rol inválido")
        };
    }
}
