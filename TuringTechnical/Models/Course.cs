using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TuringTechnical.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        public string CourseTitle { get; set; }
        public string CourseDescription { get; set; }
        public int CreditHours { get; set; }
        public int MaxClassSize { get; set; }
        public string ClassFormat { get; set; }

    }
}