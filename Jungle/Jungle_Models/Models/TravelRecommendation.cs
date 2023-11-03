using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class TravelRecommendation
    {
        [Key]
        public int Id { get; set; }

        //[MaxLength(10)]
        [Column(TypeName = "varchar(10)")]
        public string DangerLevel { get; set; }

        //[MaxLength(int.MaxValue)]
        [Column(TypeName = "varchar(MAX)")]
        public string Description { get; set; }

        //[StringLength(3, MinimumLength =3)]
        [Column(TypeName = "varchar(MAX)")]
        public string Type { get; set; }

        public Travel Travel { get; set; }
    }
}
