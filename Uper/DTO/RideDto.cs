using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Uper.Model;

namespace Uper.DTO
{
    public class RideDto
    {
        public string PickupLocation { get; set; }
 
        public string DropOffLocation { get; set; }
      
        public int Fare { get; set; }
    
        public string Status { get; set; }
        
        public int RiderId { get; set; }
        
        
        public int DriverId { get; set; }
      
    }
}
