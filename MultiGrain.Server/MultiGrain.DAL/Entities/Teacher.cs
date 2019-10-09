using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("Teacher")]
    public class Teacher : Rolee
    {

        public bool IsFullTime { get; set; }

        public bool IsProfessional { get; set; }

        public DateTime StartDate { get; set; }
        public int? DiplomaId { get; set; }

        [ForeignKey("DiplomaId")]
        public Diploma Diploma { get; set; }

        public List<Teaching> Teachings { get; set; }
    }
}
