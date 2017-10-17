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
        public string Title { get; set; }
        public string Description { get; set; }
        public int CreditHours { get; set; }
        public int MaxClassSize { get; set; }
        public int MinClassSize { get; set; }

    }
}

