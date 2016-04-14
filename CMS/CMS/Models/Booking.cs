using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CMS.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int NumberOfAdults { get; set; }

        public int NumberOfBabies { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime BookingAt { get; set; }

        [Required]
        public DateTime BookingTime { get; set; }

        [Required]
        public DateTime BookingDay { get; set; }

        [Required]
        public string ContactNumber { get; set; }
    }
}