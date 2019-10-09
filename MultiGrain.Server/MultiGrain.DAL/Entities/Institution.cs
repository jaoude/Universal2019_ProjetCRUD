using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static MultiGrain.Common.Constants;

namespace MultiGrain.DAL.Entities
{
    [Table("Institution")]
    public class Institution
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public decimal LectureDuration { get; set; }
        public string Mission { get; set; }
        public string Signature { get; set; }
        public string Title { get; set; }
        public string Vision { get; set; }
        public List<ActionPlan> ActionPlans { get; set; }
        public List<Diploma> Diplomas { get; set; }
        public List<EvaluationType> EvaluationTypes { get; set; }
        public List<Person> Persons { get; set; }
        public List<Programm> Programms { get; set; }
        public List<Room> Rooms { get; set; }
        public List<Type> Types { get; set; }
        public List<Year> Years { get; set; }
    }
}
