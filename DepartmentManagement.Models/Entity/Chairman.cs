namespace DepartmentManagement.Models.Entity
{
    public class Chairman:Teacher
    {
        public Chairman(int Id, string FirstName, string LastName, string PhoneNumber, string Email,
             int DepartmentId, DateTime JoiningDate, string Designation, string? ImageUrl, string TermStart, string TermEnd) 
            : base(Id,FirstName, LastName, PhoneNumber, Email, DepartmentId,JoiningDate, Designation, ImageUrl)
        {
            this.TermStart = TermStart;
            this.TermEnd = TermEnd;
        }

        public string TermStart { get; set; }
        public string TermEnd { get; set; }
    }
}