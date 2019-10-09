using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("Type")]
    public class Type
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
      
        public string Typecode { get; set; }
       
        public decimal Coefficient{ get; set; }
      
        public string Name { get; set; }
        public int? InstitutionId { get; set; }
        
        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }
    }
}
