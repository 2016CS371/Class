using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ClassManagment.Models
{
    public class Lecture
    {
        [Required]
        [Key]
        public int Lid { get; set; }

        [Required]
        [Display(Name ="Lecture")]
        public string Lect { get; set; }

        [Required]
        [Display(Name = "Teacher Name")]
        public string TeacherName { get; set; }

        [Required]
        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Required]
        [Display(Name = "End Time")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        [Required]
        
        [DataType(DataType.Duration)]
        public DateTime Days { get; set; }

        public IEnumerable<Faculty> faculty { get; set; }

    }
}