using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("TeachingUnit")]
    public class TeachingUnit
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Credits { get; set; }

        public string Bibliographie { get; set; }

        public string Code { get; set; }

        public string Language { get; set; }

        public string Objective { get; set; }
        public string Syllabus { get; set; }
        public string TeachingOutcomes { get; set; }
        public string Title { get; set; }

        public int? RequiredBy { get; set; }
        public List<Component> Components { get; set; }
        public List<TeachingUnitContent> TeachingUnitContents { get; set; }
        public List<Evaluation> Evaluations { get; set; }
        public List<KPI> Kpis { get; set; }
        public List<Module> Modules { get; set; }
        public List<TeachingUnit> Prerequisite { get; set; }
        public int? SemesterId { get; set; }
        [ForeignKey("SemesterId")]
        public Semester Semester { get; set; }
    }
}
