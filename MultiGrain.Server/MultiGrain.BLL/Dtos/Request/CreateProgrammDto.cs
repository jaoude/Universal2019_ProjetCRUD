using System;
using System.ComponentModel.DataAnnotations;
using static MultiGrain.Common.Constants;

namespace MultiGrain.BLL.Dtos
{
    public class CreateProgrammDto
    {
        [Required]
        public decimal Credits { get; set; }
        [Required]
        public string Admission { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string EtudesSuperieures { get; set; }
        [Required]
        public string ObjectivesEtDebouches { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string TitleAr { get; set; }
        [Required]
        public string TitleEn { get; set; }
    }
}
