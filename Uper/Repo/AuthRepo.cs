using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using Uper.Data;
using Uper.DTO;
using Uper.Model;
using Uper.Repo.IRepo;

namespace Uper.Repo
{
    public class AuthRepo : IAuth
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;
        public AuthRepo(AppDbContext context,IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<string> Login(AppUserDTO DTO)
        {
            var ExsistUser = await _context.appUsers.Where(u => u.email == DTO.Email).FirstOrDefaultAsync();
            if (ExsistUser == null)
            {
                return null;
            }
            if (ExsistUser.password == DTO.Password)
            {
                return GenerateToken(ExsistUser.email);
            }
            else
            {
                return null;
            }
           
        }
       private string GenerateToken(string email)
        {
            List<Claim> claimss = new List<Claim>()
            {
                new Claim(ClaimTypes.Email, email),


            };
            var keyy=new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_configuration["JWT:Key"]));
            var card=new SigningCredentials(keyy,SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(

                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                claims: claimss,
                signingCredentials: card,
                expires: DateTime.UtcNow.AddHours(Convert.ToDouble(_configuration["JWT:ExpireDate"])));

            var t=new JwtSecurityTokenHandler().WriteToken(token);
            return t;
        }

       
    }
}
