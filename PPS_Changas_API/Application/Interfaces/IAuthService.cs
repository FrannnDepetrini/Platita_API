﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces;

public interface IAuthService
{
    Task<string?> Login(string email, string password);
    Task<bool> Register(ClaimsPrincipal user, string email, string password, string role, string userName, int phoneNumber);
}
