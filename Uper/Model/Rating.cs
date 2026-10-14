using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Uper.Model;

namespace Uper.Model
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        [Range(1,5)]
        public int Score {  get; set; }
        [MaxLength(250)]
        public string Comment { get; set; }

        [ForeignKey(nameof(Ride))]
        public int RideId { get; set; }
        public Ride? Ride { get; set; }


    }
}
//Score(Range1 - 5)
//Comment(Max250)
//RideId
