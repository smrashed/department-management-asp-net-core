using System.ComponentModel.DataAnnotations;

namespace DepartmentManagement.Models.Entity
{
    public abstract class Person
    {
        public Person( int Id, string FirstName, string LastName, string PhoneNumber, 
            string Email, int DepartmentId)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.DepartmentId = DepartmentId;
                     
        }
        
        public int Id { get; set; }
        
        [Required,StringLength(50)]
        public string FirstName { get; set; }

        [Required,StringLength(50)]
        public string LastName { get; set; } 

        [Required,StringLength(15)]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}
