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
           
                Console.WriteLine("Enter Hire Date");
                string date = Console.ReadLine();
                DateTime hireDate = DateTime.ParseExact(date, "dd/MM/yyyy", null);
                emp.HiringDate = new HiringDate(
                    hireDate.Day,
                    hireDate.Month,
                    hireDate.Year
                    );

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
           // HiringDate hireDate = new HiringDate(10,5,2025);
           // Console.WriteLine("Hiring Date:"+ hireDate.ToString());
            #endregion

            #region Q3
            Employee[] emparr = new Employee[3];

            emparr[0] = new Employee(
                1,
                "Ahmed",
                SecurirtyLevel.DBA,
                10000,
                new HiringDate(5,5,2005),
                'M'
                );
            emparr[1] = new Employee(
                 2,
                "Amira",
                SecurirtyLevel.Guest,
                15000,
                new HiringDate(1, 1, 2030),
                'F'
                );
            emparr[2] = new Employee(
                3,
                "Marwa",
                SecurirtyLevel.SecurityOfficer,
                11000,
                new HiringDate(1, 1, 2035),
                'F'
                );
            foreach (Employee emp in emparr)
            {
                Console.WriteLine(emp.ToString());
            }
            #endregion
        }
    }
}
