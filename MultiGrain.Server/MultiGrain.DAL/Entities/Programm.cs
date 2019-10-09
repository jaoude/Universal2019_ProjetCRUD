using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("Programm")]
    public class Programm
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        public decimal Credits { get; set; }

        public string Admission { get; set; }
       
        public string Code { get; set; }
      
        public string EtudesSuperieures { get; set; }
        
        public string ObjectivesEtDebouches { get; set; }

        public string Title { get; set; }

        public string TitleAr { get; set; }

        public string TitleEn { get; set; }
        public int? InstitutionId { get; set; }
        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }

        public List<Catalog> Catalogs { get; set; }
    }
}
