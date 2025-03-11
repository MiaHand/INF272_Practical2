using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace INF272_Practical.Models
{
    public class StudentClass
    {
        // First decorator
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; }

        // Second decorator
        [Display(Name = "Name")]
        public string Name { get; set; }

        // Third decorator
        [Display(Name = "Surname")]
        public string Surname { get; set; }

        // Fourth decorator
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        // fith decorator
        [Display(Name = "Link")]
        public string myLink { get; set; }
    }
}