using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TuringTechnical.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString ="{0:mm/dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }
        [DisplayFormat(DataFormatString = "{0:mm/dd/yyyy}")]
        public DateTime EnrollmentDate { get; set; }
        public string Email { get; set; }
        [DisplayFormat(DataFormatString = "{0:###-###-####}")]
        public long PhoneNumber { get; set; }
    }
}