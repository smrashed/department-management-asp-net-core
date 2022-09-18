using DepartmentManagement.Data.DbContexts;
using DepartmentManagement.Repositories;
using DepartmentManagement.Repositories.Abstractions;
using DepartmentManagement.Services;
using DepartmentManagement.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace DepartmentManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(c => c.UseSqlServer(@"Server=(local)\SQLEXPRESS; Database=DepartmentManagementDb; Integrated Security=true"));
            builder.Services.AddTransient<IDepartmentService,DepartmentService>();
            builder.Services.AddTransient<IDepartmentRepository,DepartmentRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}