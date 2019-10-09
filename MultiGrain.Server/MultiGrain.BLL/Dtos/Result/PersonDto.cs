using System;
using System.ComponentModel.DataAnnotations;
using static MultiGrain.Common.Constants;

namespace MultiGrain.BLL.Dtos
{
    public class PersonDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}