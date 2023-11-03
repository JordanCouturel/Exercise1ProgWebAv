using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class Guide
    {
        [Key]
        public int Id { get; set; }

        //[MaxLength(25)]
        [Column(TypeName="varchar(25)")]
        public string LastName { get; set; }

        //[MaxLength(25)]
        [Column(TypeName = "varchar(25)")]
        public string FirstName { get; set; }

        //[MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string Speciality { get; set; }

        public List<Travel> Travels { get; set; }
    }
}
