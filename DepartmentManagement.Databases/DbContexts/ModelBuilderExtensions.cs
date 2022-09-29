using DepartmentManagement.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace DepartmentManagement.Database.DbContexts
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Course>().HasData(
                new Course { Id = "CSE-101", Name = "Computer Fundamentals", Credit = 3, TeacherId = 6, DepartmentId = 1 },
                new Course { Id = "CSE-102", Name = "C Programming", Credit = 3, TeacherId = 7, DepartmentId = 1 },
                new Course { Id = "CSE-103", Name = "Mathematics-I", Credit = 3, TeacherId = 8, DepartmentId = 1 },
                new Course { Id = "CSE-104", Name = "Electronics-I", Credit = 3, TeacherId = 9, DepartmentId = 1 },
                new Course { Id = "CSE-105", Name = "Mathematics-II", Credit = 3, TeacherId = 10, DepartmentId = 1 },
                new Course { Id = "CSE-106", Name = "Computer Architecture", Credit = 3, TeacherId = 11, DepartmentId = 1 },
                new Course { Id = "CSE-107", Name = "Electronics-II", Credit = 3, TeacherId = 12, DepartmentId = 1 },
                new Course { Id = "CSE-108", Name = "Statistics", Credit = 3, TeacherId = 13, DepartmentId = 1 }
            );
            modelBuilder.Entity<Student>().HasData
            (
                    new Student ( 1, "SM", "Rashedul Islam","+8801712345678", "smrashed@abc.com", 1, "14-15", "1st", DateTime.Parse("2015-04-15"),null),
                    new Student ( 2, "Md", "Abdullah Al-mamun", "+8801512343678", "mamun77@abc.com", 1, "14-15", "2nd", DateTime.Parse("2014-04-15"),3.50m),
                    new Student ( 3, "Nibir", "Hossain", "+8801912345679","nibir.hossain@xyz.com",1, "14-15",  "1st",DateTime.Parse("2015-04-15"),null),
                    new Student ( 4, "Tanzim", "Tetumir", "+8801612345778","tanzim.tetumir@abc.com", 1, "14-15","2nd",DateTime.Parse("2014-04-15"),3.25m),
                    new Student ( 5, "Md", "Shamim Hossain", "+8801312345671","jakushamim@xyz.com", 1,"14-15", "3rd", DateTime.Parse("2013-04-15"),3.86m)
            );
            modelBuilder.Entity<Teacher>().HasData(
                   new Teacher ( 6, "Md. Atikur", "Rahman", "+8801555566678", "atikur.rahman111@abc.com", 1 , DateTime.Parse("2006-09-01"), "Lecturer",null),
                   new Teacher ( 7, "Md. Alamgir", "Hossain", "+8801543566676", "alamgir.hossain112@abc.com", 1 , DateTime.Parse("2007-10-01"), "Lecturer",null),
                   new Teacher ( 8, "Md. Shohanur", "Rahman", "+8801666544479", "shohanur.rahman220@abc.com", 1 , DateTime.Parse("1999-10-10"), "Assistant Professor",null),
                   new Teacher ( 9, "Md. Muzahidur", "Rahman", "+8801666655681", "muzahidur.rahman221@abc.com", 1 , DateTime.Parse("1999-10-10"), "Assistant Professor", null),
                   new Teacher ( 10, "A.O.M", "Asaduzzaman", "+8801666566856", "aom.asaduzzaman330@abc.com", 1 , DateTime.Parse("1999-10-10"), "Associate Professor", null),
                   new Teacher ( 11, "Md", "Robiul Islam", "+8801666569958", "robiul.islam331@abc.com", 1 , DateTime.Parse("1999-10-10"), "Associate Professor", null),
                   new Teacher ( 12, "Md. Aktaruzzaman", "Babu", "+8801999566672", "aktaruzzaman.babu441@xyz.com", 1 , DateTime.Parse("2001-09-05"), "Professor", null),
                   new Teacher ( 13, "Md. Ahsanul", "Ambia", "+8801666566688","ahsanul.ambia440@abc.com", 1 , DateTime.Parse("1999-10-10"),"Professor", null)


            );
            modelBuilder.Entity<Department>().HasData(
                    new Department()
                    {
                        Id = 1,
                        Name = "CSE",
                        Description = "Dept. of CSE, Islamic University, kushtia",
                        //ChairmanId = 331
                    }
            );*/



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
