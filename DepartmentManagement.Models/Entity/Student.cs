using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentManagement.Models.Entity
{
    public class Student:Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        public string Session { get; set; }
        public string Semister { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public decimal? CGPA { get; set; }
        public Department Department { get; set; }
        public int? DepartmentId { get; set; }
    }
}