using System;
using System.ComponentModel.DataAnnotations;
using static MultiGrain.Common.Constants;

namespace MultiGrain.BLL.Dtos
{
    public class CreateTeachingUnitDto
    {
        [Required]
        public string Credits { get; set; }
        [Required]
        public string Bibliographie { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public string Objective { get; set; }
        [Required]
        public string Syllabus { get; set; }
        [Required]
        public string TeachingOutcomes { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int RequiredBy { get; set; }


    }
}
