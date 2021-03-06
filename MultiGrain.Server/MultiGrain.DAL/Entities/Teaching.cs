﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MultiGrain.DAL.Entities
{
    [Table("Teaching")]
    public class Teaching
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

        public int? GroupId { get; set; }
        [ForeignKey("GroupId")]
        public Group Group{ get; set; }

        public int? TeacherId { get; set; }

        [ForeignKey("TeacherId")]
        public Teacher Teacher { get; set; }

        public List<Session> Sessions { get; set; }
    }

}
