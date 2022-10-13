using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Auth.Constants;

namespace Auth.Services
{
    public class TokenGenerator
    {
        public string Generate()
        {
            var TokenHandler = new JwtSecurityTokenHandler();
            // para gerar o token vai ser preciso a chave secreta
            var key = Encoding.ASCII.GetBytes(TokenConstants.Secret);

            var TokenDescriptor = new SecurityTokenDescriptor()
            {
                Expires = DateTime.UtcNow.AddHours(2),

                SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature
                ),

            };
           var token = TokenHandler.CreateToken(TokenDescriptor);

           return TokenHandler.WriteToken(token);
        }
    }
}

