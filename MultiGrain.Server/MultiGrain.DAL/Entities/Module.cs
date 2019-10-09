using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("Module")]
    public class Module
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        public string IsMandatory { get; set; }
       
        public decimal RequiredCredits { get; set; }

        public int? CatalogId { get; set; }
        [ForeignKey("CatalogId")]
        public Catalog Catalog{ get; set; }
        public int? TeachingUnitId { get; set; }
        [ForeignKey("TeachingUnitId")]
        public TeachingUnit TeachingUnit { get; set; }
    }
}
