using DepartmentManagement.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace DepartmentManagement.Data.DbContexts
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = "CSE-101", Name = "Computer Fundamentals", Credit = 3, TeacherId = 110, DepartmentId = 1 },
                new Course { Id = "CSE-102", Name = "C Programming", Credit = 3, TeacherId = 111, DepartmentId = 1 },
                new Course { Id = "CSE-103", Name = "Mathematics-I", Credit = 3, TeacherId = 220, DepartmentId = 1 },
                new Course { Id = "CSE-104", Name = "Electronics-I", Credit = 3, TeacherId = 221, DepartmentId = 1 },
                new Course { Id = "CSE-105", Name = "Mathematics-II", Credit = 3, TeacherId = 330, DepartmentId = 1 },
                new Course { Id = "CSE-106", Name = "Computer Architecture", Credit = 3, TeacherId = 331, DepartmentId = 1 },
                new Course { Id = "CSE-107", Name = "Electronics-II", Credit = 3, TeacherId = 440, DepartmentId = 1 },
                new Course { Id = "CSE-108", Name = "Statistics", Credit = 3, TeacherId = 441, DepartmentId = 1 }
            );
            modelBuilder.Entity<Student>().HasData
            (
                    new Student { Id = 1147, FirstName = "SM", LastName = "Rashedul Islam", EnrollmentDate = DateTime.Parse("2015-04-15"), Semister = "1st", Session = "14-15", DepartmentId = 1, Email = "smrashed@abc.com", PhoneNumber = "+8801712345678" },
                    new Student { Id = 1148, FirstName = "Md", LastName = "Abdullah Al-mamun", EnrollmentDate = DateTime.Parse("2015-04-15"), Semister = "1st", Session = "14-15", DepartmentId = 1, Email = "mamun77@abc.com", PhoneNumber = "+8801512343678" },
                    new Student { Id = 1149, FirstName = "Nibir", LastName = "Hossain", EnrollmentDate = DateTime.Parse("2015-04-15"), Semister = "1st", Session = "14-15", DepartmentId = 1, Email = "nibir.hossain@xyz.com", PhoneNumber = "+8801912345679" },
                    new Student { Id = 1150, FirstName = "Tanzim", LastName = "Tetumir", EnrollmentDate = DateTime.Parse("2015-04-15"), Semister = "1st", Session = "14-15", DepartmentId = 1, Email = "tanzim.tetumir@abc.com", PhoneNumber = "+8801612345778" },
                    new Student { Id = 1151, FirstName = "Md", LastName = "Shamim Hossain", EnrollmentDate = DateTime.Parse("2015-04-15"), Semister = "1st", Session = "14-15", DepartmentId = 1, Email = "jakushamim@xyz.com", PhoneNumber = "+8801312345671" }
            );
            modelBuilder.Entity<Teacher>().HasData(
                   new Teacher { Id = 110, FirstName = "Md. Atikur", LastName = "Rahman", Designation = "Lecturer", PhoneNumber = "+8801555566678", Email = "atikur.rahman111@abc.com", JoiningDate = DateTime.Parse("2006-09-01"), DepartmentId = 1 },
                   new Teacher { Id = 111, FirstName = "Md. Alamgir", LastName = "Hossain", Designation = "Lecturer", PhoneNumber = "+8801543566676", Email = "alamgir.hossain112@abc.com", JoiningDate = DateTime.Parse("2007-10-01"), DepartmentId = 1 },
                   new Teacher { Id = 220, FirstName = "Md. Shohanur", LastName = "Rahman", Designation = "Assistant Professor", PhoneNumber = "+8801666544479", Email = "shohanur.rahman220@abc.com", JoiningDate = DateTime.Parse("1999-10-10"), DepartmentId = 1 },
                   new Teacher { Id = 221, FirstName = "Md. Muzahidur", LastName = "Rahman", Designation = "Assistant Professor", PhoneNumber = "+8801666655681", Email = "muzahidur.rahman221@abc.com", JoiningDate = DateTime.Parse("1999-10-10"), DepartmentId = 1 },
                   new Teacher { Id = 330, FirstName = "A.O.M", LastName = "Asaduzzaman", Designation = "Associate Professor", PhoneNumber = "+8801666566856", Email = "aom.asaduzzaman330@abc.com", JoiningDate = DateTime.Parse("1999-10-10"), DepartmentId = 1 },
                   new Teacher { Id = 331, FirstName = "Md", LastName = "Robiul Islam", Designation = "Associate Professor", PhoneNumber = "+8801666569958", Email = "robiul.islam331@abc.com", JoiningDate = DateTime.Parse("1999-10-10"), DepartmentId = 1 },
                   new Teacher { Id = 441, FirstName = "Md. Aktaruzzaman", LastName = "Babu", Designation = "Professor", PhoneNumber = "+8801999566672", Email = "aktaruzzaman.babu441@xyz.com", JoiningDate = DateTime.Parse("2001-09-05"), DepartmentId = 1 },
                   new Teacher { Id = 440, FirstName = "Md. Ahsanul", LastName = "Ambia", Designation = "Professor", PhoneNumber = "+8801666566688", Email = "ahsanul.ambia440@abc.com", JoiningDate = DateTime.Parse("1999-10-10"), DepartmentId = 1 }


            );
            modelBuilder.Entity<Department>().HasData(
                    new Department()
                    {
                        Id = 1,
                        Name = "CSE",
                        Description = "Dept. of CSE, Islamic University, kushtia",
                        //ChairmanId = 331
                    }
            );



            /* modelBuilder.Entity<Teacher>()
                 .HasMany<Course>(t => t.Courses)
                 .WithOne(c => c.Teacher)
                 .HasForeignKey(s => s.TeacherId);

             modelBuilder.Entity<Student>()
                 .HasOne<Department>(s => s.Department)
                 .WithMany(d => d.Students)
                 .HasForeignKey(s => s.DepartmentId);

             modelBuilder.Entity<Course>()
                 .HasOne<Department>(c => c.Department)
                 .WithMany(d => d.Courses)
                 .HasForeignKey(c => c.DepartmentId);*/


        }
    }
}
