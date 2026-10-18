using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Uper.DTO
{
    public class VehcileDto
    {
        public string Model { get; set; }
       
        public string PlateNumber { get; set; }
        [Required]
        public string Color { get; set; }
      
        public int DriverId { get; set; }
    }
}
