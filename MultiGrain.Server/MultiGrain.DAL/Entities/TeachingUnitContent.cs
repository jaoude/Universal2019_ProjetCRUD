using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("TeachingUnitContent")]
    public class TeachingUnitContent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Contenu{ get; set; }

        public int Position { get; set; }
        public int? TeachingUnitId { get; set; }

        [ForeignKey("TeachingUnitId")]
        public TeachingUnit TeachingUnit { get; set; }
    }
}
