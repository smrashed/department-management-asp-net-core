using System.ComponentModel.DataAnnotations;

namespace DepartmentManagement.Models.Entity
{
    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        [Range(1,5)]
        public int Credit { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public Teacher Teacher { get; set; }
        public int? TeacherId { get; set; }
    }
}