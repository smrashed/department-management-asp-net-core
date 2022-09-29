using DepartmentManagement.Database.DbContexts;
using DepartmentManagement.Databases.DbContexts;
using DepartmentManagement.Models.Entity;
using DepartmentManagement.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentManagement.Repositories
{
    public class StudentRepository : Repository<Student>,IStudentRepository
    {
        AppDbContext _db;
        public StudentRepository(AppDbContext db): base(db)
        {
            _db = db;
        }

        public override Student GetById(int id)
        {
            return _db.Students.FirstOrDefault(d => d.Id == id);
        }
    }
}
