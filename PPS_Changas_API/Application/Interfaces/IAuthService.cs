using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IAuthService
{
    Task<string?> Login(string email, string password);
    Task<bool> Register(string? creatorRole, string email, string password, string role, string userName, int phoneNumber);

    Task ForgotPasswordAsync(string email);
}
