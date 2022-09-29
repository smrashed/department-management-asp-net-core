using DepartmentManagement.Models.Entity;

namespace DepartmentManagement.App.Models.DepartmentModels
{
    public class DepartmentListViewModel
    {
        
             
        //public string Name { get; set; }
        //public string Description { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
