using DepartmentManagement.Data.DbContexts;
using DepartmentManagement.Models.Entity;

namespace DepartmentManagement.Repositories
{
    public class StudentRepository
    {
        AppDbContext _db;
        //constructor
        public StudentRepository()=> _db= new AppDbContext();
        
        public Student GetStudentById(int id) => _db.Students.FirstOrDefault(x => x.Id == id);
        public ICollection<Student> GetStudents() => _db.Students.ToList();
    }
}
