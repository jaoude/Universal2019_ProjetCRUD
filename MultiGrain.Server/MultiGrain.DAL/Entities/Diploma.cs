using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("Diploma")]
    public class Diploma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        public decimal Code { get; set; }
       
        public decimal Points { get; set; }
        
        public string Title { get; set; }

        public int? InstitutionId { get; set; }
        
        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }

        public List<Teacher> Teachers { get; set; }
    }
}
