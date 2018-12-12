using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClassManagment.Models
{
    public class Section
    {
        [Required]
        [Key]
        public int Secid { get; set; }

        [Required]
        public string Name { get; set; }
    }
}