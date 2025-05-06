using Application.Interfaces;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

public class AuthService(IUserRepository userRepository, ITokenService tokenService, IPasswordHasher passwordHasher) : IAuthService
{

    private readonly IUserRepository _userRepository = userRepository;
    private readonly ITokenService _tokenService = tokenService;
    private readonly IPasswordHasher _passwordHasher = passwordHasher;

    public async Task<string?> Login(string email, string password)
    {
        var user = await _userRepository.GetUserByEmail(email);
        if (user == null || !_passwordHasher.VerifyPassword(password, user.Password))
        {
            return null;
        }

        return _tokenService.GenerateToken(user);
    }

    public async Task<bool> Register(string? creatorRole, string email, string password, string role, string userName, int phoneNumber)
    {
        var exisitingUser = await _userRepository.GetUserByEmail(email);
        if (exisitingUser is not null)
        {
            return false;
        }

        if (!Enum.TryParse(role, out RolesEnum userRole))
        {
            throw new ArgumentException("Rol inválido");
        }

        if (userRole == RolesEnum.SysAdmin || userRole == RolesEnum.Moderator)
        {
            if (creatorRole != RolesEnum.SysAdmin.ToString())
            {
                throw new UnauthorizedAccessException("Solo un SysAdmin puede registrar usuarios de tipo SysAdmin o Moderator.");
            }
        }

        var hashedPassword = _passwordHasher.HashPassword(password);

        var newUser = CreateUserByRole(email, hashedPassword, userRole, userName, phoneNumber);

        await _userRepository.Create(newUser);

        return true;
    }

    private User CreateUserByRole(string email, string password, RolesEnum role, string userName, int phoneNumber)
    {
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
            RolesEnum.Client => new Client
            {
                Email = email,
                Password = password,
                Role = role.ToString(),
                UserName = userName,
                PhoneNumber = phoneNumber
            },
            RolesEnum.Support => new Support
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


