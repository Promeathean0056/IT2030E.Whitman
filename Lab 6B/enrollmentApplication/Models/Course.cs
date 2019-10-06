using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace enrollmentApplication.Models
{
    public class Course
    {
        [ErrorMessage = "Course id"]
        int Course_id;

        [Required]
        [StringLength(150), ErrorMessage = "Title"]
        String Course_Title;
        [ErrorMessage = "descriptiion"]
        String Description;
        [Required]
        [Range(typeof(decimal) 1 - 4, ErrorMessage = "Credits"]
        int Credits;
    }
}