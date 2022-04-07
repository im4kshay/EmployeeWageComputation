using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmpWageBuilderArray
    {
        //constants
        public const int EMF_FULL_TIME = 1;
        public const int EMF_PART_TIME = 2;
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmpWageBuilderArray"/> class.
        /// </summary>
        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        /// <summary>
        /// Adds the company emp wage.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="empRatePerHour">The emp rate per hour.</param>
        /// <param name="numOfWorkingDays">The number of working days.</param>
        /// <param name="maxHoursPerMonth">The maximum hours per month.</param>
        public void AddCompanyEmpWage(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, emp_Wage_Per_Hr, working_Days_Per_Month, max_Hrs_Per_Month);
            numOfCompany++;
        }

        /// <summary>
        /// Computes the emp wage.
        /// </summary>
        public void ComputeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }

        /// <summary>
        /// Computes the emp wage.
        /// </summary>
        /// <param name="companyEmpWage">The company emp wage.</param>
        /// <returns></returns>
        public int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int total_Emp_Hrs = 0;
            int totalWorkingDays = 0;
            int daily_Emp_Wage = 0;
            while (total_Emp_Hrs <= companyEmpWage.max_Hrs_Per_Month && totalWorkingDays < companyEmpWage.working_Days_Per_Month)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case EMF_PART_TIME:
                        empHrs = 4;
                        break;
                    case EMF_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                daily_Emp_Wage = empHrs * companyEmpWage.emp_Wage_Per_Hr;
                Console.WriteLine("Employee wage for day {0} is: {1} for {2} Hrs", totalWorkingDays, daily_Emp_Wage, empHrs);
                companyEmpWage.total_Emp_Wage += daily_Emp_Wage;
                total_Emp_Hrs += empHrs;
                totalWorkingDays++;
            }
            return total_Emp_Hrs * companyEmpWage.emp_Wage_Per_Hr;
        }

    }
}
