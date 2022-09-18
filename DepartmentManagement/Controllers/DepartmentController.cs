using DepartmentManagement.Models.Entity;
using DepartmentManagement.Models.ViewModel.DepartmentModels;
using DepartmentManagement.Services;
using DepartmentManagement.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentManagement.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentService _departmentServices;
        public DepartmentController(IDepartmentService departmentServices)
        {
            _departmentServices = departmentServices;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DepartmentCreateViewModel model)
        {
            var department = new Department()
            {
                //Id = model.Id,
                Name = model.Name,
                Description = model.Description
            };
            var isAdded = _departmentServices.Add(department);
            if (isAdded)
            {
                return RedirectToAction("List");
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            var department = _departmentServices.GetById(id);
            if (department == null)
            {
                throw new Exception("Department not found");
            }
            DepartmentEditViewModel model = new DepartmentEditViewModel()
            {
                Id = id,
                Name = department.Name,
                Description = department.Description
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(DepartmentEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Department department = new Department()
                {
                    Id = model.Id,
                    Name = model.Name,
                    Description = model.Description
                };
                var isUpdated = _departmentServices.Update(department);
                if (isUpdated)
                {
                    return RedirectToAction("List");
                }
                
            }
            return View();

        }
        public IActionResult List()
        {
            var departments = _departmentServices.GetAll();
            var model = new DepartmentListViewModel()
            {
                Departments = departments.ToList()
            };
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            
            return RedirectToAction("List");
        }


    }
}
