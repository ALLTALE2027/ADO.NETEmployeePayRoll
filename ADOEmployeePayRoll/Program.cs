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
                Console.WriteLine("\nSelect option :\n1.Get Payroll Table Details\n2.Add data to tables\n3.Update Pay details\n4.Get records in date_range\n6.Exit\nProvide option number : --> ");
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
                    case 3:
                        emp.UpdateBasicPay();
                        OptionsDisplay();
                        break ;
                    case 4:
                        emp.GetRowsByDateRange();
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