using DepartmentManagement.Database.DbContexts;
using DepartmentManagement.Models.Entity;
using DepartmentManagement.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentManagement.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _db;
        public Repository(DbContext db)
        {
            _db = db;
        }
        private DbSet<T> Entity
        {
            get
            {
                return _db.Set<T>();
            }
        }
        
        public virtual bool Add(T entity)
        {
            Entity.Add(entity);
            return _db.SaveChanges() > 0;
        }
        public virtual bool Update(T entity)
        {
            Entity.Update(entity);
            return _db.SaveChanges() > 0;
        }
        public virtual bool Delete(T entity)
        {
            Entity.Remove(entity);
            return _db.SaveChanges() > 0;
        }

        public virtual ICollection<T> GetAll()
        {
            return Entity.ToList();
        }

        public abstract T GetById(int id);
        

       
        /*public bool IsSaved()
        {
            return _db.SaveChanges() > 0;
        }*/
    }
}
