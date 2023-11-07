using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class Option
    {
        public string Name { get; set; }
        public double Price { get; set; }

        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }

        public virtual Reservation? Reservation { get; set; }

        public bool EstChoisi { get; set; }


        [ForeignKey("Travel")]
        public int TravelId { get; set; }

        public virtual Travel travel { get; set; }



    }
}
