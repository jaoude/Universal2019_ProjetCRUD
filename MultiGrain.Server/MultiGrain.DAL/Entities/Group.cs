using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("Group")]
    public class Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Desc { get; set;}

        public int? ComponentId { get; set; }

        [ForeignKey("ComponentId")]
        public Component Component{ get; set; }
        public int? CatalogId { get; set; }

        [ForeignKey("CatalogId")]
        public Catalog Catalog { get; set; }

        public List<Teaching> Teachings { get; set; }
    }
}
