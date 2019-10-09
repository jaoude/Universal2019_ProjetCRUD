using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("Catalog")]
    public class Catalog
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        public string ProgramEducationObjectives{ get; set; }

        public int? ProgrammId { get; set; }

        [ForeignKey("ProgrammId")]
        public  Programm Programm { get; set; }

        public int? YearId { get; set; }
        [ForeignKey("YearId")]
        public Year Year{ get; set; }
    }
}
