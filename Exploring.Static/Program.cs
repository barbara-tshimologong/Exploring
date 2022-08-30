using Exploring.Static.Models;


namespace Exploring.Static
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Hello, We are going to explore a static class");

            Console.WriteLine("Would you like to capture a new employee?  Enter Y to continue:");

            string? isContinue = Console.ReadLine();

            while (isContinue != null && isContinue.ToUpper()=="Y")
            {
                Console.WriteLine("Please enter the First Name:");

                var firstName = Console.ReadLine();

                firstName ??= string.Empty;

                Console.WriteLine($"Thank you, now enter the Surname:");

                var surName = Console.ReadLine();

                //surName = null;

                surName ??= String.Empty;

                //var newEmployee = AddNewEmployee(firstName, surName);

                

                Employee employee = new()
                {
                    FirstName = firstName,
                    Surname = surName,
                 };


                StaffManagement.AddEmployee();

                var fullname = employee.FullName();

                Console.WriteLine($"{fullname} has been added to the Company");

                Console.WriteLine("Would you like to capture a new employee?  Enter Y to continue:");

                isContinue = Console.ReadLine();

            }



            Console.WriteLine($" the number of employees at our company is now {StaffManagement.NoOfEmployees}!");
        }

        public static int Counting { get; set; }

        private static string AddNewEmployee(string firstName, string surname)
            {

            Employee employee = new()
            {
                FirstName = firstName,
                Surname = surname
            };

            return employee.FullName();

            }

   }
}