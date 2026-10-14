using System.ComponentModel.DataAnnotations;
using Uper.Model;

namespace Uper.DTO
{
    public class UserCreateDto
    {
        public string FullName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required, Phone]
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
