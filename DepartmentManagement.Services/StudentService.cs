using DepartmentManagement.Models.Entity;
using DepartmentManagement.Repositories.Abstractions;
using DepartmentManagement.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentManagement.Services
{
    public class StudentService : Service<Student>,IStudentService
    {
        IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
            : base(studentRepository)
        {
            _studentRepository = studentRepository;
        }
    }
}
