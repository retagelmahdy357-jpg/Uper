using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Uper.Model;

namespace Uper.Model
{
    public class Ride
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength( 150)]
       public string PickupLocation {  get; set; }
        [Range(20,5000)]
        public int Fare {  get; set; }
        [Required]
        public string Status {  get; set; }
        [ForeignKey(nameof(Rider))]
        public int RiderId {  get; set; }
        public User? Rider { get; set; }
        [ForeignKey(nameof(Driver))]
        public int DriverId {  get; set; }
        public User? Driver { get; set; }
        public Payment? Payment { get; set; }
        public Rating? Rating { get; set; }



    }
}
//DropOffLocation(Required, Max150)
//Fare(Range20 - 5000)
//Status(Required)
//RiderId
//DriverId

