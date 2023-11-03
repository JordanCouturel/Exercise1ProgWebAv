using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class Destination
    {
        [Key]
        public int Id { get; set; }

        //[MaxLength(30)]
        [Column(TypeName = "varchar(30)")]
        public string name { get; set; }

        //[MaxLength(30)]
        [Column(TypeName = "varchar(30)")]
        public string Region { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }

        public List<Travel> Travels { get; set; }
    }
}
