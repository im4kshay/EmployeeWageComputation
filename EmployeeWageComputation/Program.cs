using EmpWageComputation;
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

            //Uc-1 Check Employee is Present or Absent
            //EmpAttendance.GetEmpAttendance();

            //Uc-2 Calculate Daily Employee Wage
            //EmployeeWage.GetEmpWage();

            //Uc-3 Add Part time Employee & Wage
            //PartTimeEmployee.PartTimeWage();

            //UC-4 Solving using Switch Case Statement
            //SwitchCase.DailyEmpWage();

            //UC-5 Calculating Wages for a Month
            //MonthWages.MonthlyEmpWage();

            //UC-6 Calculate Wages till a condition of total working hours or days is reached for a month
            //WageTillCondition.GetWageTillCondition();

            //UC-7 Refactor the Code to write a Class Method to Compute Employee Wage
            //RefactorWithClassMethod.RefactorGetMonthlyEmpWage();

            //UC-8 Compute Employee Wage for multiple companies
            //EmpWageForMultipleCompanies.ComputeEmpWage("Google", 20, 2, 10);
            //EmpWageForMultipleCompanies.ComputeEmpWage("Microsoft", 10, 4, 20);
            //EmpWageForMultipleCompanies.ComputeEmpWage("Deloitte", 15, 3, 15);

            //UC-9 Ability to save the Total Wage for Each Company
            //SaveTotalWageByCompany google = new SaveTotalWageByCompany("Google", 10, 4, 20);
            //google.TotalWageForEachCompany();
            //Console.WriteLine(google.ToString());

            //SaveTotalWageByCompany microsoft = new SaveTotalWageByCompany("Microsoft", 20, 5, 20);
            //microsoft.TotalWageForEachCompany();
            //Console.WriteLine(microsoft.ToString());

            //SaveTotalWageByCompany deloitte = new SaveTotalWageByCompany("Deloitte", 30, 3, 30);
            //deloitte.TotalWageForEachCompany();
            //Console.WriteLine(deloitte.ToString());

            //UC-10 Ability to manage Employee Wage of multiple companies
            //EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //empWageBuilder.AddCompanyEmpWage("Google", 10, 4, 20);
            //empWageBuilder.AddCompanyEmpWage("Microsoft", 20, 5, 20);
            //empWageBuilder.AddCompanyEmpWage("Deloitte", 30, 3, 30);
            //empWageBuilder.ComputeEmpWage();

            //UC-11 Ability to manage Employee Wage of multiple companies using Interface approach
            //EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            //empWageBuilder.AddCompanyEmpWage("Google", 10, 4, 20);
            //empWageBuilder.AddCompanyEmpWage("Microsoft", 20, 5, 20);
            //empWageBuilder.AddCompanyEmpWage("Deloitte", 30, 3, 30);
            //empWageBuilder.ComputeEmpWage();

            //UC-12 Refactor to have list of multiple companies to manage Employee Wage.
            //EmpBuilderArray empWageBuilder = new EmpBuilderArray();
            //empWageBuilder.AddCompanyEmpWage("Google", 10, 4, 20);
            //empWageBuilder.AddCompanyEmpWage("Microsoft", 20, 5, 20);
            //empWageBuilder.AddCompanyEmpWage("Deloitte", 30, 3, 30);
            //empWageBuilder.ComputeEmpWage();

            //UC-13 Store the Dail Wage along with the Total WageStore the Daily Wage along with the Total Wage
            //EmpWageBuilderList empWageBuilder = new EmpWageBuilderList();
            //empWageBuilder.AddCompanyEmpWageToList("Google", 10, 4, 20);
            //empWageBuilder.AddCompanyEmpWageToList("Microsoft", 20, 5, 20);
            //empWageBuilder.AddCompanyEmpWageToList("Deloitte", 30, 3, 30);
            //empWageBuilder.ComputeEmpWage();

            //UC-14 Ability to get the Total Wage when queried by Company
            EmpWageBuilderList empWageBuilder = new EmpWageBuilderList();
            empWageBuilder.AddCompanyEmpWageToList("Google", 10, 4, 20);
            empWageBuilder.AddCompanyEmpWageToList("Microsoft", 20, 5, 20);
            empWageBuilder.AddCompanyEmpWageToList("Deloitte", 30, 3, 30);
            empWageBuilder.ComputeEmpWage();

            Console.ReadLine();
        }
    }
}
