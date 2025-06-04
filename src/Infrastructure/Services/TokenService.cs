using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TokenService(IConfiguration configuration, ApplicationContext context) : ITokenService
    {
        private readonly IConfiguration _configuration = configuration;
        private readonly ApplicationContext _context = context;
        public string GenerateToken(User user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),       
                new Claim(JwtRegisteredClaimNames.Email, user.Email),               
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim(JwtRegisteredClaimNames.GivenName, user.UserName),
                new Claim("hasJobs", _context.Jobs.Any(j => j.ClientId == user.Id).ToString()),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public string GenerateTemporaryToken(User user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Name, "resetPassword"),
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(5),
                signingCredentials: creds
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            var oneTimeToken = new OneTimeToken
            {
                Token = tokenString,
                UserId = user.Id,
                Expiration = token.ValidTo,
                IsUsed = false
            };

            _context.OneTimeTokens.Add(oneTimeToken);
            _context.SaveChangesAsync();
            
            return tokenString;
        }

        public string GetEmailFromToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!);

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = _configuration["Jwt:Issuer"],
                ValidAudience = _configuration["Jwt:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ClockSkew = TimeSpan.Zero 
            };

            try
            {
                var stored = _context.OneTimeTokens.FirstOrDefault(t => t.Token == token);
                if (stored == null)
                    throw new Exception("Token not recognized");
                if (stored.IsUsed)
                    throw new Exception("Token already used");
                if (stored.Expiration < DateTime.UtcNow)
                    throw new Exception("Token has expired");




                var principal = tokenHandler.ValidateToken(token, validationParameters, out _);

                var isReset = principal.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Name)?.Value;

                if (isReset != "resetPassword") throw new Exception("This token is not for resetting password");

                var email = principal.Claims.FirstOrDefault(c =>
                    c.Type == ClaimTypes.Email || c.Type == JwtRegisteredClaimNames.Email)?.Value;

                if (email == null) throw new Exception("Email claim not found in token");

                stored.IsUsed = true;
                _context.SaveChangesAsync();

                return email;
            }
            catch (SecurityTokenExpiredException)
            {
                throw new Exception("Token has expired");
            }
            catch (Exception ex)
            {
                throw new Exception("Invalid token: " + ex.Message);
            }
        }

    }
}
