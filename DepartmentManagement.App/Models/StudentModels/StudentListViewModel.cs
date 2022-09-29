using DepartmentManagement.Models.Entity;

namespace DepartmentManagement.App.Models.StudentModels
{
    public class StudentListViewModel
    {
        public string DepartmentName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
