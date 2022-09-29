using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentManagement.Models.Entity
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
       /* public Chairman Chairman { get; set; }
        [ForeignKey("Chairman")]
        public int ChairmanId { get; set; }*/
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
