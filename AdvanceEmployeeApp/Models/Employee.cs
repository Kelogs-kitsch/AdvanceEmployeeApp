using System.ComponentModel.DataAnnotations;
namespace AdvanceEmployeeApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeID { get; set; }// Unique ID
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Status { get; set; } // Active / Inactive
        public string Role { get; set; } // Admin / Employee
    }
}
