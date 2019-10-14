using System;
using System.ComponentModel.DataAnnotations;
using static MultiGrain.Common.Constants;

namespace MultiGrain.BLL.Dtos
{
    public class CreateActionPlanDto
    {
        [Required]
        public decimal Completed { get; set; }

        [Required]
        [MaxLength(LAST_NAME_CHAR_LEN)]
        [Display(Name = DISPLAY_PERSON_LAST_NAME)]
        public string Action { get; set; }
    }
}