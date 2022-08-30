namespace Exploring.Static
{

    static class StaffManagement
    {
        public static int NoOfEmployees { get; set; }
        public static void AddEmployee()
        {
            NoOfEmployees = NoOfEmployees + 1;

        }
        public static void RemoveEmployee()
        {
            NoOfEmployees = NoOfEmployees -1;
        }
    }
}
