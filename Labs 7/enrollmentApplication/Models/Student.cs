using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace enrollmentApplication.Models
{
    public class Student
    {
        [Display(Name = "Student ID")]
        public virtual int Student_id { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "A last name is Required")]
        [StringLength(50, ErrorMessage = "Last Name")]
        [InvalidChars("*", ErrorMessage = "can not use that symbol.")]

        public virtual String Last_Name { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "A First name is required")]
        [StringLength(50, ErrorMessage = "First Name cannot be more than 50 characters")]
        [InvalidChars("*")]
        public virtual String First_Name { get; set; }

        [MinimumAge(20)]
        public virtual int Age { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string State { get; set; }


    }
}