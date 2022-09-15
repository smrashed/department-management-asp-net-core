namespace DepartmentManagement.Repositories.Abstractions
{
    public interface IRepository<T> where T: class
    {
        T GetById(int id);
        ICollection<T> GetAll();
        public bool Add(T entity);
        public bool Update(T entity);
        public bool Delete(T entity);

    }
}
