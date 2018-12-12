using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClassManagment.Models
{
    public class Faculty
    {
        [Required]
        [Key]
        public int Fid { get; set; }

        [Required]

        public string Name { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        [Required]
        
        public int Salary { get; set; }

        [Required]
        
        public string Lecture { get; set; }

         
    }
}