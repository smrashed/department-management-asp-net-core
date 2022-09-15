using DepartmentManagement.Data.DbContexts;
using DepartmentManagement.Repositories.Abstractions;

namespace DepartmentManagement.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        AppDbContext _db;
        public Repository()
        {
            _db = new AppDbContext();
        }
        public virtual bool Add(T entity)
        {
            _db.Add(entity);
            return _db.SaveChanges()>0;
        }

        public virtual bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
