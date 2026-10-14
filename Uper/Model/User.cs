using System.ComponentModel.DataAnnotations;

namespace Uper.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(100),MinLength(3)]
        public string FullName { get; set; }
        [Required,EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required,Phone]
        public string Phone { get; set; }
        public string Role {  get; set; }
        public Vehicle? Vehicle { get; set; }
        public List<Ride> ?RideDrivers { get; set; }= new List<Ride>();
        public List<Ride> ?RideRiders { get; set; }= new List<Ride>();

    }
}
