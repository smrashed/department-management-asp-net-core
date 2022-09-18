using DepartmentManagement.Models.Entity;
using DepartmentManagement.Repositories.Abstractions;
using DepartmentManagement.Services.Abstractions;

namespace DepartmentManagement.Services
{
    public class DepartmentService:IDepartmentService
    {
        IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
            //_departmentRepository = new DepartmentRepository();
        }
        public bool Update(Department model)
        {
            
            return _departmentRepository.Update(model);
        }
        public bool Delete(Department model)
        {
            return _departmentRepository.Delete(model);
        }
        public bool Add(Department model)
        {
            return _departmentRepository.Add(model);
        }

        public Department GetById(int id)
        {
            return _departmentRepository.GetById(id);
        }

        public ICollection<Department> GetAll()
        {
            return _departmentRepository.GetAll();
        }
    }
}
