using System.ComponentModel.DataAnnotations;

namespace DepartmentManagement.Models.ViewModel.DepartmentModels
{
    public class DepartmentCreateViewModel
    {
        /*[Required]
        public int Id { get; set; }*/
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
