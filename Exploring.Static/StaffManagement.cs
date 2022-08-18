namespace Exploring.Static
{

    static class StaffManagement
    {

        public static int NoOfEmployees { get; set; }
        public static void AddEmployee()
        {
            NoOfEmployees = +1;
        }
        public static void RemoveEmployee()
        {
            NoOfEmployees = -1;
        }
    }
}
