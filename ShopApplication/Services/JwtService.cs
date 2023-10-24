using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using Microsoft.IdentityModel.Tokens;

using ShopApplication.Entity;
using ShopApplication.Models;

namespace ShopApplication.Services
{
    public class JwtService : IJwtService
    {
        private ApplicationDbContext _context;

        public JwtService(ApplicationDbContext context)
        {
            _context = context;
        }

        public String Generate(User user)
        {

            var secretKey = Encoding.UTF8.GetBytes("sjDjbivHNhp7gC06qfkbJfsfZbPYRYUPbh22pxn1ofVjYTdweZ6GGofW");
            var signincreadintial = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256Signature);
            var claims = _getClaims(user);
            var descriptor = new SecurityTokenDescriptor
            {
                Issuer = "http://localhost:5213/",
                Audience = "http://localhost:5213/",
                IssuedAt = DateTime.Now,
                NotBefore = DateTime.Now.AddMinutes(0),
                Expires = DateTime.Now.AddHours(1),
                SigningCredentials = signincreadintial,
                Subject = new ClaimsIdentity(claims),

            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var securityToken = tokenHandler.CreateToken(descriptor);
            var Jwt = tokenHandler.WriteToken(securityToken);
            return Jwt;
        }



        private IEnumerable<Claim> _getClaims(User user)
        {
            var list = new List<Claim>
            {
                new Claim(ClaimTypes.Name,user.Name),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),

            };
            //var roles = _context.Roles.ToArray();
            //foreach(var role in roles)
            //{
            //    list.Add(new Claim(ClaimTypes.Role, role.Name));
            //}
            //foreach (var role in roles)
            //{
            //    list.Add(new Claim(ClaimTypes.Role, role.Name));

            //}
            return list;

        }
    }
}
