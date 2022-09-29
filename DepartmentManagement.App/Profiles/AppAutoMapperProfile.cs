using AutoMapper;
using DepartmentManagement.App.Models.DepartmentModels;
using DepartmentManagement.App.Models.StudentModels;
using DepartmentManagement.Models.Entity;

namespace DepartmentManagement.App.Configurations
{
    public class AppAutoMapperProfile : Profile
    {
        public AppAutoMapperProfile()
        {
            //Department model
            CreateMap<Department, DepartmentCreateViewModel>();
            CreateMap<Department, DepartmentEditViewModel>();
            CreateMap<Department, DepartmentListViewModel>();
            CreateMap<DepartmentCreateViewModel,Department >();
            CreateMap<DepartmentEditViewModel,Department >();
            CreateMap<DepartmentListViewModel,Department >();

           

            //Student model
            CreateMap<Student, StudentListViewModel>();
            CreateMap<Student, StudentEditViewModel>();
            CreateMap<StudentCreateViewModel, Student>();
            CreateMap< StudentEditViewModel, Student > ();
            CreateMap< StudentListViewModel, Student > ();

        }
    }
}
