namespace Exploring.Static.Models
{
    public class Employee
    {
        public Employee()
        {
            FirstName = String.Empty;
            Surname = String.Empty;
        }

        public  int EmployeeId {get; set; }

        public string FirstName { get; set; } 

        public string Surname { get; set; }

        public string FullName()
        {
            return $"{FirstName} {Surname}";

        }

    }
}
