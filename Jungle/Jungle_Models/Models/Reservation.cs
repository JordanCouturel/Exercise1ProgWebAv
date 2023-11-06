using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateReservation { get; set; }

        public int NbPlacesReservés { get; set; }

        public double PrixFinal { get; set; }


        [ForeignKey("Travel")]
        public int TravelId { get; set; }

        public virtual Travel travel { get; set; }


       public virtual List<Option>? Options { get; set; }

    }
}
