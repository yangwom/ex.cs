using Auth.Models;
public class TokenGenerator
{

    private ClaimsIdentity AddClaims(User user) 
{
    var claims = new ClaimsIdentity();

    claims.AddClaim(new Claim(ClaimTypes.Country, user.Country));

    return claims;
}
    public string generate(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();

        var tokenDescriptor = new SecurityTokenDescriptor()
        {
            Subject = AddClaims(user),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(TokenConstants.Secret)), SecurityAlgorithms.HmacSha256Signature),
            Expires = DateTime.Now.AddDays(TokenConstants.DaysExpire)
        };

        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}