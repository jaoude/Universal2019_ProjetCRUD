using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("KPI")]
    public class KPI
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }
       
        public string Code { get; set; }
       
        public string Text { get; set; }

        public int? OutcomeId { get; set; }

        [ForeignKey("OutcomeId")]
        public Outcome Outcome{ get; set; }

        public int? TeachingUnitId { get; set; }

        [ForeignKey("TeachingUnitId")]
        public TeachingUnit TeachingUnit { get; set; }
    }
}
