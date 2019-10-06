using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotaions;

namespace enrollmentApplication.Models
{
    public class Enrollment
    {
        int Enrollment_id;
        int Student_id;
        int Course_id;
        [Required]
        [RegularExpression("A-Fa-f")]
        Char Grade;
        Object Student;
        Object Course;
        bool IsActive;
        [Required]
        [ErrorMessage = "Assigned Campus"]
        String AssignedCampus;
        [Required]
        [ErrorMessage = "Enrolled in Semester"]
        String EnrollmentSemester;
        [Required]
        [Range(typeof(decimal) 2018-9999]
        int EnrollmentYear;

    }
}