using System.ComponentModel.DataAnnotations;

namespace DepartmentManagement.App.Models.StudentModels
{
    public class StudentEditViewModel
    {

        [Required]
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
        public int DepartmentId{ get; set; }
    }
}
