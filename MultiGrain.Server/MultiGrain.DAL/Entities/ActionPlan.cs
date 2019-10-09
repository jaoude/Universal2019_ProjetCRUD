using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("ActionPlan")]
    public class ActionPlan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public decimal Completed { get; set; }

        public string Action { get; set; }

        public int? InstitutionId { get; set; }

        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }
    }

}
