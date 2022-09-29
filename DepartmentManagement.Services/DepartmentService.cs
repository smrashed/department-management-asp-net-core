using DepartmentManagement.Models.Entity;
using DepartmentManagement.Repositories.Abstractions;
using DepartmentManagement.Services.Abstractions;

namespace DepartmentManagement.Services
{
    public class DepartmentService:Service<Department>,IDepartmentService
    {
        IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
            : base(departmentRepository)
        {
            _departmentRepository = departmentRepository;
           
        }
       
    }
}
