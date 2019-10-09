using System;
using System.ComponentModel.DataAnnotations;
using static MultiGrain.Common.Constants;

namespace MultiGrain.BLL.Dtos
{
    public class UploadFileDocumentDto
    {
        public int? InstitutionId { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string NameFr { get; set; }
        public string Action { get; set; }
    }
}