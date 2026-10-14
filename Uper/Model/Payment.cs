using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Uper.Model;

namespace Uper.Model
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        [Range(20,5000)]
        public int Amount {  get; set; }
        [Required]
        public string PaymentMethod {  get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        public string Status {  get; set; }
        [ForeignKey(nameof(Ride))]
        public int RideId { get; set; }
        public Ride Ride { get; set; }

    }
}
//Amount(Range20 - 5000),
//PaymentMethod(Required)
//PaymentDate(Required)
//Status(Required)
//RideId

