using Application.Interfaces;
using Application.Models.Requests;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

public class AuthService(IUserRepository userRepository, ITokenService tokenService, IPasswordHasher passwordHasher, IEmailService emailService)
    : IAuthService
{

    private readonly IUserRepository _userRepository = userRepository;
    private readonly ITokenService _tokenService = tokenService;
    private readonly IPasswordHasher _passwordHasher = passwordHasher;
    private readonly IEmailService _emailService = emailService;

    public async Task<string?> Login(LoginRequest request)
    {
        var user = await _userRepository.GetUserByEmail(request.Email);
        if (user == null || !_passwordHasher.VerifyPassword(request.Password, user.Password))
        {
            return null;
        }

        return _tokenService.GenerateToken(user);
    }

    public async Task<bool> Register(RegisterRequest request)
    {
        var exisitingUser = await _userRepository.GetUserByEmail(request.Email);
        if (exisitingUser is not null)
        {
            return false;
        }

        var hashedPassword = _passwordHasher.HashPassword(request.Password);

        var user = new Client
        {
            Email = request.Email,
            Password = hashedPassword,
            Province = request.Province,
            City = request.City,
            Role = RolesEnum.Client.ToString(),
            UserName = request.UserName,
            PhoneNumber = request.PhoneNumber
        };

        await _userRepository.Create(user);

        return true;
    }


    public async Task<bool> RegisterForSysAdmin(RegisterForSysAdminRequest request)
    {
        var exisitingUser = await _userRepository.GetUserByEmail(request.Email);
        if (exisitingUser is not null)
        {
            return false;
        }

        if (request.Role != RolesEnum.Moderator.ToString() &&
            request.Role != RolesEnum.Support.ToString() &&
            request.Role != RolesEnum.SysAdmin.ToString())
        {
            throw new ArgumentException("Invalid role");
        }

        var hashedPassword = _passwordHasher.HashPassword(request.Password);

        var roleEnum = Enum.Parse<RolesEnum>(request.Role);

        var newUser = CreateUserByRole(
            request.Email,
            hashedPassword,
            roleEnum,
            request.UserName,
            request.PhoneNumber
        );

        await _userRepository.Create(newUser);

        return true;
    }

    private static User CreateUserByRole(string email, string password, RolesEnum role, string userName, string phoneNumber)
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
            RolesEnum.Support => new Support
            {
                Email = email,
                Password = password,
                Role = role.ToString(),
                UserName = userName,
                PhoneNumber = phoneNumber
            },
            _ => throw new ArgumentException("Invalid role")
        };
    }

    // Método para la recuperación de contraseña
    public async Task ForgotPasswordAsync(string email)
    {
        // Verificar si el usuario existe
        var user = await _userRepository.GetUserByEmail(email);
        if (user == null)
        {
            // No le decimos al cliente si el usuario no existe por razones de seguridad.
            return;
        }

        // Generar un token JWT para el usuario
        var token = _tokenService.GenerateTemporaryToken(user);

        // Enviar el email con el enlace de recuperación
        await _emailService.SendPasswordRecoveryEmailAsync(email, token);
    }

    public async Task ResetForgottenPassword(ResetForgottenPasswordRequest request)
    {
        var email = _tokenService.GetEmailFromToken(request.Token);

        var user = await _userRepository.GetUserByEmail(email);

        if (user is null)
        {
            throw new Exception("User not found");
        }

        user.Password = _passwordHasher.HashPassword(request.NewPassword);

        await _userRepository.Update(user);
    }

    public async Task ChangePasswordAsync(int userId, ChangePasswordRequest request)
    {
        var user = await _userRepository.GetById(userId);
        if (user == null)
            throw new Exception("Invalid user");

        var isCurrentPasswordValid = _passwordHasher.VerifyPassword(request.Password, user.Password);
        if (!isCurrentPasswordValid)
            throw new Exception("Wrong password");

        user.Password = _passwordHasher.HashPassword(request.NewPassword);
        await userRepository.Update(user);

    }

}


