namespace ADOEmployeePayRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Payroll Service program using ADO.NET \n");
            EmployeeADO emp = new EmployeeADO();
            OptionsDisplay();

            void OptionsDisplay()
            {
                Console.WriteLine("\nSelect option :\n1.Get Payroll Table Details\n2.Add data to tables\n6.Exit\nProvide option number : --> ");
                int option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        emp.GetEmployeeDetails();
                        OptionsDisplay();
                        break;
                    case 2:
                        emp.AddEmpDetails();
                        OptionsDisplay();
                        break;
                    default:
                        Console.WriteLine("Enter correct option");
                        break;
                }
            }

        }
    
    }
}