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

public class AuthService(IUserRepository userRepository, ITokenService tokenService, IPasswordHasher passwordHasher, IEmailService emailService) : IAuthService
{

    private readonly IUserRepository _userRepository = userRepository;
    private readonly ITokenService _tokenService = tokenService;
    private readonly IPasswordHasher _passwordHasher = passwordHasher;
    private readonly IEmailService _emailService = emailService;
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
}


