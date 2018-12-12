using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClassManagment.Models
{
    public class Holiday
    {
        [Required]
        [Key]
        public int Holidayid { get; set; }

        [Required]
        [Display(Name = "Holiday")]
        public string Holiday1 { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}