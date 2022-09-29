using DepartmentManagement.Models.Entity;
using System.ComponentModel.DataAnnotations;

namespace DepartmentManagement.App.Models.DepartmentModels
{
    public class DepartmentCreateViewModel
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
       // public ICollection<Teacher> Teachers { get; set; }
    }
}
