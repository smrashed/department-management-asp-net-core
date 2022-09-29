using DepartmentManagement.Models.Entity;
using DepartmentManagement.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using DepartmentManagement.App.Models.DepartmentModels;

namespace DepartmentManagement.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentServices;
        private readonly IMapper _mapper;
        public DepartmentController(IDepartmentService departmentServices,IMapper mapper)
        {
            _departmentServices = departmentServices;
            _mapper = mapper;
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
            if (ModelState.IsValid)
            {
                var department = _mapper.Map<Department>(model);
                var isAdded = _departmentServices.Add(department);
                if (isAdded)
                {
                    return RedirectToAction("List");
                    
                }
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
            DepartmentEditViewModel model = _mapper.Map<DepartmentEditViewModel>(department);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(DepartmentEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Department department = _mapper.Map<Department>(model);
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
           // var model = _mapper.Map<DepartmentListViewModel>(ICollection<departments>);
            var model = new DepartmentListViewModel()
            {
                Departments = departments.ToList()
            };
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            var department = _departmentServices.GetById(id);
            if(department == null)
            {
                return RedirectToAction("List");
            }
            var isDeleted = _departmentServices.Delete(department);
            if(isDeleted) return RedirectToAction("List");
            return RedirectToAction("List");
        }
        


    }
}
