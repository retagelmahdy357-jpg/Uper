using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Uper.Model;

namespace Uper.DTO
{
    public class PaymentDTO
    {
        public int Amount { get; set; }
        [Required]
        public string PaymentMethod { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        public string Status { get; set; }
     
        public int RideId { get; set; }
    }
}
