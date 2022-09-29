using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentManagement.Models.Entity
{
    public class Student:Person
    {
       /* public Student()
        {
        }*/

        public Student(int Id,string FirstName, string LastName, string PhoneNumber,string Email,
            int DepartmentId,  string Session,string Semister, DateTime EnrollmentDate, Decimal? CGPA) 
            : base( Id, FirstName, LastName, PhoneNumber, Email, DepartmentId)      
        {
            this.Session = Session;
            this.EnrollmentDate = EnrollmentDate;
            this.CGPA = CGPA;
            this.Semister = Semister;
        }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        public string Session { get; set; }
        public string Semister { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public decimal? CGPA { get; set; }
       /* public Department Department { get; set; }
        public int? DepartmentId { get; set; }*/
    }
}