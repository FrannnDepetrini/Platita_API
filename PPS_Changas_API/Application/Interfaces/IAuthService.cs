using Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IAuthService
{
    Task<string?> Login(string email, string password);
    Task<bool> Register(string email, string password, RolesEnum role, string userName, int phoneNumber);
}
