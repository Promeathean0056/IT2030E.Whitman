using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace enrollmentApplication.Models
{
    public class Enrollment
    {
        int Enrollment_id;
        int Student_id;
        int Course_id;
        Char Grade;
        Object Student;
        Object Course;
        bool IsActive;
        String AssignedCampus;
        String EnrollmentSemester;
        int EnrollmentYear;

    }
}