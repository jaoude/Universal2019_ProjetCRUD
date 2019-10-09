using System;
using System.ComponentModel.DataAnnotations;
using static MultiGrain.Common.Constants;

namespace MultiGrain.BLL.Dtos
{
    public class CreateInstitutionDto
    {
        public decimal LectureDuration { get; set; }
        public string Mission { get; set; }
        public string Signature { get; set; }
        public string Title { get; set; }
        public string Vision { get; set; }
    }
}
