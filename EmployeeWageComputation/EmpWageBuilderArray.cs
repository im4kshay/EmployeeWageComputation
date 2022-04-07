using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public interface IComputeEmpWage
    {
        void AddCompanyEmpWage(string companyName, int working_Days_Per_Month, int max_Hrs_Per_Month, int empRate);
        void ComputeEmpWage();
    }
    public class EmpWageBuilderArray : IComputeEmpWage
    {
        public const int EMP_FULL_TIME = 1;
        public const int EMP_PART_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }
        public void AddCompanyEmpWage(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, emp_Wage_Per_Hr, working_Days_Per_Month, max_Hrs_Per_Month);
            numOfCompany++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int total_Emp_Hrs = 0;
            int daily_Emp_Wage = 0;
            while (total_Emp_Hrs <= companyEmpWage.max_Hrs_Per_Month && totalWorkingDays < companyEmpWage.working_Days_Per_Month)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case EMP_FULL_TIME:
                        empHrs = 4;
                        break;
                    case EMP_PART_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                total_Emp_Hrs += empHrs;
                Console.WriteLine("Employee wage for day {0} for {1} Hrs", totalWorkingDays, empHrs);

            }
            return total_Emp_Hrs * companyEmpWage.emp_Wage_Per_Hr;

            //int totalEmpWage = totalEmpHrs * this.empRatePerHour;
            //this.totalEmpWage = totalEmpWage;
            //Console.WriteLine("\nTotal Employee wage for company  " + company + "  is "+ totalEmpWage);

        }
    }
}
