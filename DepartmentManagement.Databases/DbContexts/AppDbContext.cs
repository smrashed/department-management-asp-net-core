using DepartmentManagement.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace DepartmentManagement.Databases.DbContexts
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions option)
           : base(option)
        {

        }
        public DbSet<Person> Person { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Chairman> Chairmen { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=(local)\SQLEXPRESS; Database=DepartmentManagementDb; Integrated Security=true";
            optionsBuilder.UseSqlServer(connectionString);
        }*/
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Seed();
        }*/


    }
}
