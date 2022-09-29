using DepartmentManagement.Models.Entity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentManagement.App.Models.StudentModels
{
    public class StudentCreateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter enrollment date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [Required(ErrorMessage = "Please enter session")]
        public string Session { get; set; }

        [Required(ErrorMessage = "Please enter semister")]
        public string Semister { get; set; }

        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter phone number")]
        public string PhoneNumber { get; set; }
        //public IFormFile? Image { get; set; }

        public decimal? CGPA { get; set; }
        //public Department Department { get; set; }
        public int  DepartmentId { get; set; }

        //[Required(ErrorMessage = "Please enter department")]
        //public SelectListItem Departments { get; set; }
    }
}
