using DepartmentManagement.Models.Entity;
using DepartmentManagement.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AutoMapper;
using DepartmentManagement.App.Models.StudentModels;

namespace DepartmentManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentServices;
        private readonly IDepartmentService _departmentServices;
        private readonly IMapper _mapper;
        public StudentController(IStudentService studentServices, 
            IDepartmentService departmentServices, IMapper mapper)
        {
            _studentServices = studentServices;
            _departmentServices = departmentServices;           
            _mapper = mapper;
        } 
        public IActionResult Create()
        {
            var departmentList = _departmentServices.GetAll();

            var departments = departmentList.Select(d => new SelectListItem()
            {
                Text = d.Name,
                Value = d.Id.ToString()
            }).ToList();

            departments.Insert(0, new SelectListItem()
            {
                Text = "----Choose Department---",
                Value = String.Empty
            });
            //ViewBag.Title = "Student";
            ViewBag.Departments = departments;
            
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
    
                var student = _mapper.Map<Student>(model);
                
                var isAdded = _studentServices.Add(student);
                if (isAdded)
                {
                    return RedirectToAction("List");
                }
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            var student = _studentServices.GetById(id);
            var departmentList = _departmentServices.GetAll();

            var departments = departmentList.Select(d => new SelectListItem()
            {
                Text = d.Name,
                Value = d.Id.ToString()
            }).ToList();

           
            ViewBag.Departments = departments;

            var model = _mapper.Map<StudentEditViewModel>(student);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(StudentEditViewModel model)
        {
            if (ModelState.IsValid)
            {

                var student = _mapper.Map<Student>(model);

                var isUpdated = _studentServices.Update(student);
                if (isUpdated)
                {
                    return RedirectToAction("List");
                }
            }
            return View();
        }

        public IActionResult List()
        {
            var students = _studentServices.GetAll();
            var model = new StudentListViewModel()
            {
                Students = students          
            };
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            var student = _studentServices.GetById(id);
            var isDeleted = _studentServices.Delete(student);
            if (isDeleted)
            {
                return RedirectToAction("List");
            }
            return RedirectToAction("List");
        }
    }
}
