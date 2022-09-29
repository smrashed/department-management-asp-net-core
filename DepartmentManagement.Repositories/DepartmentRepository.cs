using DepartmentManagement.Database.DbContexts;
using DepartmentManagement.Databases.DbContexts;
using DepartmentManagement.Models.Entity;
using DepartmentManagement.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace DepartmentManagement.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private readonly AppDbContext _db;
        public DepartmentRepository(AppDbContext db) : base(db)
        { 
            _db = db; 
        }
        public override Department GetById(int id)
        {
           return _db.Departments.FirstOrDefault(d => d.Id == id);
        }
    }
}
