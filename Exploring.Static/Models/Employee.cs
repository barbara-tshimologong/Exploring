namespace Exploring.Static.Models
{
    public class Employee
    {
        public  int EmployeeId {get; set; }

        public string FirstName { get; set; } = String.Empty;

        public string Surname { get; set; } = String.Empty;

        public string FullName()
        {
            return $"{FirstName} {Surname}";
        }
    }
}
