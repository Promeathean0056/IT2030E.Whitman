using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace enrollmentApplication.Models
{
    public class Course : IValidatableObject
    {
        [Display(Name = "Course id")]
        public virtual int Course_id { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "A Course title is required")]
        [StringLength(150, ErrorMessage = "A Course Title cannot be more than 150 Characters")]
        public virtual String Course_Title { get; set; }
        
        [Display(Name = "Desctiption")]
        public virtual String Description { get; set; }
        [Display(Name = "Nemuber of credits")]
        [Required(ErrorMessage = "A number of credits is required")]
        [Range(1, 4, ErrorMessage = "Course credits must be a value between 1-4")]
        public virtual float Credits { get; set; }

        public virtual string InstructorName { get; set;  }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Credits < 1 || Credits > 4)
            {
                yield return (new ValidationResult("Credits must be between 1 and 4"));
            }
            if(Description.Split(' ').Length > 100)
            {
                yield return (new ValidationResult("your description is too verbose"));
            }
            throw new NotImplementedException();
        }
    }
}