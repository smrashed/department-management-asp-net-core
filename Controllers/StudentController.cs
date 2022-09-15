using DepartmentManagement.Data.DbContexts;
using DepartmentManagement.Models.Entity;
using DepartmentManagement.Models.ViewModel;
using DepartmentManagement.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentManagement.Controllers
{
    public class StudentController : Controller
    {
        StudentRepository _studentRepository;
        public StudentController()
        {
            _studentRepository = new StudentRepository();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        /*[HttpPost]
        public IActionResult Create(StudentCreateVm model)
        {
            var student = new Student()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                EnrollmentDate = model.EnrollmentDate,
                Semister= model.Semister,
                Session=model.Session,

            };
            _studentRepository

        }*/
    }
}
