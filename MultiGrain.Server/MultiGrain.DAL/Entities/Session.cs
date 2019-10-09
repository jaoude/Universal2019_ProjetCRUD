using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("Session")]
    public class Session
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id{ get; set; }
       
        public DateTime FromDate{ get; set; }
       
        public DateTime ToDate{ get; set; }
        public int? RoomId { get; set; }
        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        [ForeignKey("TeachingId")]
        public int? TeachingId { get; set; }
        public Teaching Teaching{ get; set; }
    }
}
