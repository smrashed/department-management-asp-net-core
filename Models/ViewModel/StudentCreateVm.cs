using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentManagement.Models.ViewModel
{
    public class StudentCreateVm
    {
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        /*[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]*/
        public DateTime EnrollmentDate { get; set; }
        public string Session { get; set; }
        public string Semister { get; set; }
        
        public decimal? CGPA { get; set; }
    }
}
