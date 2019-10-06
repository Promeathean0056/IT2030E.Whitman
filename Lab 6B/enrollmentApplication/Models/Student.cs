using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotaions;

namespace enrollmentApplication.Models
{
    public class Student
    {
        [ErrorMessage = "Student ID"]
        int Student_id;

        [Required]
        [StringLength(50), ErrorMessage = "Last Name"]
        String Last_Name;
        [Required]
        [StringLength(50), ErrorMessage = "First Name"]
        String First_Name;
    }
}