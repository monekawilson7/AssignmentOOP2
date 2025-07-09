using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP2
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SecurirtyLevel SecurirtyLevel { get; set; }
        public decimal Salary { get; set; }
        //public DateTime HireDate { get; set; }
        public HiringDate HiringDate { get; set; }

        private char gender;
        public char Gender { 
        get { return gender; }
            set {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    throw new ArgumentException("Gender must be either 'M' or 'F'.");
            }
        }
        public override string ToString()
        {
            return $"ID: {Id}\n" +
                $"Name: {Name}\n" +
                $":Securirty Level: {SecurirtyLevel}\n" +
                $"Salary: {string.Format("{0:C}", Salary)}\n" +
               // $"Hire Date: {HireDate.ToShortDateString()}\n" +
                $"Hire Date: {HiringDate}\n" +
                $"Gender: {(Gender == 'M' ? "Male" : "Female")}\n";

        }

        public Employee(int id, string name, SecurirtyLevel securirtyLevel, decimal salary, HiringDate hiringDate, char gender) {
            Id = id;
            Name = name;
            SecurirtyLevel = securirtyLevel;
            Salary = salary;
            HiringDate = hiringDate;
            Gender = gender;
        }
        public Employee() { }

    }
}
