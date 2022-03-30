using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Empolyee Wage Computation Program\n");
            EmpAttendance.GetEmpAttendance(); 
            EmployeeWage.GetEmpWage();
            PartTimeEmployee.PartTimeWage();
            Console.ReadLine();
        }
    }
}
