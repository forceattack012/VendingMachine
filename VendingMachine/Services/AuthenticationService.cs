using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using VendingMachine.Entities;
using VendingMachine.Helper;
using VendingMachine.Models;
using VendingMachine.Services.Interfaces;

namespace VendingMachine.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IConfiguration _config;

        public AuthenticationService(IConfiguration config)
        {
            _config = config;
        }
        public TokenResponse GenerateToken(User user)
        {
            var claims = new List<Claim>();
            claims.Add(new Claim("username", user.UserName));
            claims.Add(new Claim("displayname", user.UserName));

            claims.Add(new Claim(ClaimTypes.Role, user.Role.Type));

            var token = JwtHelper.GetJwtToken(
                user.UserName,
                _config["JwtToken:SigningKey"],
                _config["JwtToken:Issuer"],
                _config["JwtToken:Audience"],
                TimeSpan.FromMinutes(120),
                claims.ToArray()
              );

            return new TokenResponse()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expire = token.ValidTo
            };
        }
    }
}
