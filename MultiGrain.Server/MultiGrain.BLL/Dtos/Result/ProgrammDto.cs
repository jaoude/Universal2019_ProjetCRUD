using System;
using System.ComponentModel.DataAnnotations;
using static MultiGrain.Common.Constants;


namespace MultiGrain.BLL.Dtos
{
    public class ProgrammDto
    {
        public decimal Credits { get; set; }

        public string Admission { get; set; }

        public string Code { get; set; }

        public string EtudesSuperieures { get; set; }

        public string ObjectivesEtDebouches { get; set; }

        public string Title { get; set; }

        public string TitleAr { get; set; }

        public string TitleEn { get; set; }

    }
}
