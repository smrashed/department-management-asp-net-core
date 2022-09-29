using DepartmentManagement.Databases.DbContexts;
using DepartmentManagement.Repositories;
using DepartmentManagement.Repositories.Abstractions;
using DepartmentManagement.Services;
using DepartmentManagement.Services.Abstractions;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DepartmentManagement.App.Configurations
{
    public static class AppConfiguration
    {
        //Extend Method WebApplicationBuilder
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<AppDbContext>(c => c.UseSqlServer(@"Server=(local)\SQLEXPRESS; Database=DepartmentDb; Integrated Security=true"));
            builder.Services.AddTransient<IDepartmentService, DepartmentService>();
            builder.Services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            builder.Services.AddTransient<IStudentService, StudentService>();
            builder.Services.AddTransient<IStudentRepository, StudentRepository>();
        }
    }
}
