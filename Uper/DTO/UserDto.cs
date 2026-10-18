using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Uper.Model;

namespace Uper.DTO
{
    [Index (nameof(Email),IsUnique = true)]
    public class UserCreateDto
    {
        public string FullName { get; set; }
       
        public string Email { get; set; }
       
        public string Password { get; set; }
       
        public string Phone { get; set; }
        public string Role { get; set; }
       
    }

    public class UserReadDto
    {
        [Required]
        public string FullName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        public string Role { get; set; }

    }
}
