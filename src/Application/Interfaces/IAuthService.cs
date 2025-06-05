using Application.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IAuthService
{
    Task<string?> Login(LoginRequest request);
    Task<bool> Register(RegisterRequest request);
    Task<bool> RegisterForSysAdmin(RegisterForSysAdminRequest request);
    Task ForgotPasswordAsync(string email);

    Task ChangePasswordAsync(int userId, ChangePasswordRequest request);
    Task ResetForgottenPassword(ResetForgottenPasswordRequest request);
}
