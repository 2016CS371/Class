using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClassManagment.Models
{
    public class Notice
    {
        [Required]
        [Key]
        public int Eventid { get; set; }

        [Required]
        [Display(Name = "Notice")]
        
        public string EventName { get; set; }

        [Required] 
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}