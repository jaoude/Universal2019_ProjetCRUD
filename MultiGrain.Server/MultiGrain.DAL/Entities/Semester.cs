using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("Semester")]
    public class Semester
    {
     
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        public int Value { get; set; }
        public int? YearId { get; set; }
        [ForeignKey("YearId")]
        public Year Year { get; set; }

        public List<TeachingUnit> TeachingUnits { get; set; }
    }
}
