using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultiGrain.DAL.Entities
{
    [Table("Component")]
    public class Component
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public decimal S01 { get; set; }

        public decimal S02 { get; set; }

        public decimal S03 { get; set; }

        public decimal S04 { get; set; }

        public decimal S05 { get; set; }

        public decimal S06 { get; set; }

        public decimal S07 { get; set; }

        public decimal S08 { get; set; }

        public decimal S09 { get; set; }

        public decimal S10 { get; set; }

        public decimal S11 { get; set; }

        public decimal S12 { get; set; }

        public decimal S13 { get; set; }

        public decimal S14 { get; set; }

        public decimal S15 { get; set; }

        public decimal S16 { get; set; }

        public int? TypeId { get; set; }

        public int? TeachingUnitId { get; set; }


        [ForeignKey("TypeId")]
        public Type Type{ get; set; }

        [ForeignKey("TeachingUnitId")]
        public TeachingUnit TeachingUnit{ get; set; }

        public List<Group> Groups { get; set; }
    }
}
