using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("FileDocument")]
    public class FileDocument
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FileName { get; set; }
        public string ContentType { get; set; }

        public string NameAr { get; set; }

        public string NameEn { get; set; }

        public string NameFr { get; set; }

        public string Action { get; set; }

        public DateTime UploadedOn { get; set; }

        public string UploadedBy { get; set; }

        public byte[] Data { get; set; }

        public int? InstitutionId { get; set; }

        [ForeignKey("InstitutionId")]
        public Institution Institution { get; set; }
    }

}
