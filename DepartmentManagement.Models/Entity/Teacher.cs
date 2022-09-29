using System.ComponentModel.DataAnnotations;

namespace DepartmentManagement.Models.Entity
{
    public class Teacher:Person
    {
        public Teacher(int Id, string FirstName, string LastName, string PhoneNumber, string Email,
             int DepartmentId, DateTime JoiningDate, string Designation,string? ImageUrl)
            : base(Id, FirstName,LastName, PhoneNumber, Email, DepartmentId)
        {
            this.JoiningDate = JoiningDate;
            this.Designation = Designation;
            this.ImageUrl = ImageUrl;   

        }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }
        public string Designation { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<Course> Courses { get; set; }
        /*public Department Department { get; set; }
        public int? DepartmentId { get; set; }*/


    }
}