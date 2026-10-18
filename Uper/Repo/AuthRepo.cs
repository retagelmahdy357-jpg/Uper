using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using AutoMapper.Execution;
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
        public AuthRepo(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<string> Login(AppUserDTO userDTO)
        {
            var eu = await _context.appUsers.Where(x => x.email == userDTO.Email).FirstOrDefaultAsync();
            if (eu == null)
            {
                return null;
            }
            if (eu.password == userDTO.Password)
            {
                return GenerateToken(eu.email, eu.Role);
            }
            else
            {

                return null;
            }
            

        }

        private string GenerateToken(string email, string role)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Role, role),
                new Claim(ClaimTypes.Email,email),
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
            var Card = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(

                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                signingCredentials: Card,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(Convert.ToDouble(_configuration["JWT:ExpireDate"]
                )
                )
                );
            var stringtoken=new JwtSecurityTokenHandler().WriteToken(token);
               


            return stringtoken;
        }
     

       
    


        public async Task<bool> Rigester(AppUser user)
        {
            var usr = _context.appUsers.Any(x => x.email == user.email);
            if (usr)
            {
                return false;
            }
            await _context.AddAsync(user);
            return true;


        }
    }
}
