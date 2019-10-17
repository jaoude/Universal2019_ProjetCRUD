using System;
using System.ComponentModel.DataAnnotations;
using static MultiGrain.Common.Constants;
namespace MultiGrain.BLL.Dtos
{
    public class TeachingUnitDto
    {
        public string Credits { get; set; }

        public string Bibliographie { get; set; }

        public string Code { get; set; }

        public string Language { get; set; }

        public string Objective { get; set; }
        public string Syllabus { get; set; }
        public string TeachingOutcomes { get; set; }
        public string Title { get; set; }

        public int RequiredBy { get; set; }


    }
}
