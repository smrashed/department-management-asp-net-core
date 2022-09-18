using System.ComponentModel.DataAnnotations;

namespace DepartmentManagement.Models.Entity
{
    public abstract class Person
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Display(Name = "Full Name")]
        public string GetFullName { get=>FirstName+LastName; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string? ImageUrl { get; set; }
    }
}
