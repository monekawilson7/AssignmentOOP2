using System;

namespace AssignmentOOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            try
            {
                Employee emp = new Employee();
                Console.WriteLine("Enter Employee ID:");
                emp.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name:");
                emp.Name = Console.ReadLine();
                Console.WriteLine("Enter Security Level (Guest, Developer, Secretary, DBA):");
                string secInput = Console.ReadLine();
                emp.SecurirtyLevel = (SecurirtyLevel)Enum.Parse(typeof(SecurirtyLevel), secInput, true);
                Console.WriteLine("Enter Salary:");
                emp.Salary = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Hire Date:");
                emp.HireDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter Gender");
                emp.Gender = Convert.ToChar(Console.ReadLine().ToUpper());
                Console.WriteLine("Employee Information");
                Console.WriteLine(emp.ToString());
            }
            catch (Exception ex)
            { 
            Console.WriteLine(ex.ToString()); 
            }
            #endregion

            #region Q2
            HiringDate hireDate = new HiringDate(10,5,2025);
            Console.WriteLine("Hiring Date:"+ hireDate.ToString());
            #endregion

        }
    }
}
