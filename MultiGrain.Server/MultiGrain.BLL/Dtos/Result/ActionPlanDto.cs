using System;
using System.ComponentModel.DataAnnotations;
using static MultiGrain.Common.Constants;


namespace MultiGrain.BLL.Dtos
{
    public class ActionPlanDto
    {
        public decimal Completed { get; set; }

        public string Action { get; set; }

    }
}
