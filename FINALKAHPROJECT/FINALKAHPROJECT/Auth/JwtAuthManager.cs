using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace FINALKAHPROJECT.Auth
{
    public static class JwtAuthManager
    {
        public static HMACSHA256 Secret = GetSecretKey();
        public static string SecretKey = Convert.ToBase64String(Secret.Key);
        public static string GenerateJWTToken(string username,int expire_in_minutes = 10)
        {
            var symmetric_key = Convert.FromBase64String(SecretKey);
            var tokenHandler = new JwtSecurityTokenHandler();
            var now = DateTime.UtcNow;

            var tokenDesciptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name,username)
                }),
                Expires = now.AddMinutes(Convert.ToInt32(SecretKey)),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symmetric_key),SecurityAlgorithms.HmacSha256)
            };

            var stoken = tokenHandler.CreateToken(tokenDesciptor);
            var token = tokenHandler.WriteToken(stoken);
             return token;
        }

        public static ClaimsPrincipal GetPrincipal(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadToken(token) as JwtSecurityToken;
                if (jwtToken == null)
                    return null;
                var symetricKey = Convert.FromBase64String(SecretKey);
                var validationParameters = new TokenValidationParameters()
                {
                    RequireExpirationTime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = new SymmetricSecurityKey(symetricKey)
                };
                SecurityToken securityToken;
                var principal = tokenHandler.ValidateToken(token,validationParameters,out securityToken);
                return principal;
            } catch
            {
                return null;
            }
        }

        private static HMACSHA256 GetSecretKey()
        {
            HMACSHA256 hmacsha256 = new HMACSHA256();
            return hmacsha256;
        }


    }
}
