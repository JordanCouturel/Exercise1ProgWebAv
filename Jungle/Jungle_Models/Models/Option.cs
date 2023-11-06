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

    }
}
