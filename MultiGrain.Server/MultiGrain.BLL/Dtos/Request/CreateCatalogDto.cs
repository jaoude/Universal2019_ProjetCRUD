using System;
using System.ComponentModel.DataAnnotations;
using static MultiGrain.Common.Constants;

namespace MultiGrain.BLL.Dtos
{
    public class CreateCatalogDto
    {
        [Required]
        public string ProgramEducationObjectives { get; set; }
    }
}