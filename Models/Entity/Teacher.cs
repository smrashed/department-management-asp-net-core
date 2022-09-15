using System.ComponentModel.DataAnnotations;

namespace DepartmentManagement.Models.Entity
{
    public class Teacher:Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Joining Date")]
        public DateTime JoiningDate { get; set; }
        public string Designation { get; set; }
        public ICollection<Course> Courses { get; set; }
        public Department Department { get; set; }
        public int? DepartmentId { get; set; }


    }
}