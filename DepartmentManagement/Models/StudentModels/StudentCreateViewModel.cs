using DepartmentManagement.Models.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentManagement.Models.ViewModel.StudentModels
{
    public class StudentCreateViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Required]
        public string Session { get; set; }
        [Required]
        public string Semister { get; set; }
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public IFormFile Image { get; set; }
        public decimal? CGPA { get; set; }
        [Required]
        public Department Department { get; set; }
    }
}
