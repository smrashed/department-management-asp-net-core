using DepartmentManagement.Data.DbContexts;
using DepartmentManagement.Models.Entity;
using DepartmentManagement.Repositories.Abstractions;

namespace DepartmentManagement.Repositories
{
    public class DepartmentRepository:IDepartmentRepository
    {
        AppDbContext _db;
        //constructor
        public DepartmentRepository(AppDbContext db)
        {
            _db = db;
        }

        public bool Update(Department model)
        {
            _db.Update(model);
            return _db.SaveChanges() > 0;
        }
        public bool Delete(Department model)
        {
            _db.Remove(model);
            return _db.SaveChanges() > 0;
        }
        public bool Add(Department model)
        {
            _db.Add(model);
            return _db.SaveChanges() > 0;
        }

        public Department GetById(int id)
        {
            return _db.Departments.FirstOrDefault(x => x.Id == id);
        }

        public ICollection<Department> GetAll()
        {
            return _db.Departments.ToList(); /*Include(d => d.Teachers)
                                    .Include(d=>d.Students)
                                        .Include(d=>d.Courses)
                                            .ToList();*/
        }
    }
}
