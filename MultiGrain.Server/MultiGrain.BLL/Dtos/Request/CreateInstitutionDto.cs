using System;
using System.ComponentModel.DataAnnotations;
using static MultiGrain.Common.Constants;

namespace MultiGrain.BLL.Dtos
{
    public class CreateInstitutionDto
    {
        public int id { get; set; }
        [Required]
        public decimal LectureDuration { get; set; }
        [Required]
        public string Mission { get; set; }
        [Required]
        public string Signature { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Vision { get; set; }
    }
}
