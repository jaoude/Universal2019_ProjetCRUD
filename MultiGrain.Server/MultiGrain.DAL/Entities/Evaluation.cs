using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static MultiGrain.Common.Constants;
namespace MultiGrain.DAL.Entities
{
    [Table("Evaluation")]
    public class Evaluation
    {
        [Key]
        public int EvaluationId{ get; set; }
       
        public decimal calculator { get; set; }
       
        public decimal duration { get; set; }
       
        public decimal openbook { get; set; }
       
        public string date{ get; set; }
       
        public decimal notes { get; set; }
       
        public decimal weight { get; set; }

        public int? TeachingUnitId { get; set; }
        [ForeignKey("TeachingUnitId")]
        public TeachingUnit TeachingUnit { get; set; }
        public int? TypeId { get; set; }
        [ForeignKey("TypeId")]
        public Type Type { get; set; }
    }
}
