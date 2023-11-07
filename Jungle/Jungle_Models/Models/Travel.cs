using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class Travel
    {
        [Key]
        public int Id { get; set; }

        //[MaxLength(25)]
        [Column(TypeName = "varchar(25)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(MAX)")]
        public string Description { get; set; }

        //[Column(TypeName = "double(10,2)")]
        //[DisplayFormat(DataFormatString ="{0:c2}")]
        public double Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime DepartureDate { get; set; }

        [Range(7,21)]
        public int Duration { get; set; }


        [Range(15, 55, ErrorMessage = "Le nombre de places doit être entre 15 et 55.")]
        public int NbPlaceDispo { get; set; }

        public int NbPlacesMinPourQueVoyageAitLieu { get; set; }

        public string Statut { get; set; } = "Prévu";


        [ForeignKey("Destination")]
        public int DestinationId { get; set; }
        Destination Destination { get; set; }

        [ForeignKey("Guide")]
        public int GuideId { get; set; }
        public Guide Guide { get; set; }

        [ForeignKey("TravelRecommendation")]
        public int? TravelRecommendationId { get; set; }
        public TravelRecommendation TravelRecommendation { get; set; }


        public virtual List<Option> Options { get; set; }
    }
}
