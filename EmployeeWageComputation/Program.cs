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

            //EmpAttendance.GetEmpAttendance();
            //EmployeeWage.GetEmpWage();
            //PartTimeEmployee.PartTimeWage();
            //SwitchCase.DailyEmpWage();
            //MonthWages.MonthlyEmpWage();
            //WageTillCondition.GetWageTillCondition();
            //RefactorWithClassMethod.RefactorGetMonthlyEmpWage();
            //EmpWageForMultipleCompanies.ComputeEmpWage("Google", 20, 2, 10);
            //EmpWageForMultipleCompanies.ComputeEmpWage("Microsoft", 10, 4, 20);
            //EmpWageForMultipleCompanies.ComputeEmpWage("Deloitte", 15, 3, 15);

            SaveTotalWageByCompany google = new SaveTotalWageByCompany("Google", 10, 4, 20);
            google.TotalWageForEachCompany();
            Console.WriteLine(google.ToString());

            SaveTotalWageByCompany microsoft = new SaveTotalWageByCompany("Microsoft", 20, 5, 20);
            microsoft.TotalWageForEachCompany();
            Console.WriteLine(microsoft.ToString());

            SaveTotalWageByCompany deloitte = new SaveTotalWageByCompany("Deloitte", 30, 3, 30);
            deloitte.TotalWageForEachCompany();
            Console.WriteLine(deloitte.ToString());

            Console.ReadLine();
        }
    }
}
