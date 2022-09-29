namespace DepartmentManagement.Services.Abstractions
{
    public interface IService<T> where T : class
    {
        public bool Add(T entity);
        public bool Update(T entity);
        public bool Delete(T entity);
        public T GetById(int id);
        public ICollection<T> GetAll();
    }
}
