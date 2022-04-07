using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class CompanyEmpWage
    {
        //variables
        public string company;
        public int emp_Wage_Per_Hr;
        public int working_Days_Per_Month;
        public int max_Hrs_Per_Month;
        public int total_Emp_Wage;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyEmpWage"/> class.
        /// </summary>
        /// <param name="company">The company.</param>
        /// <param name="empRatePerHour">The emp rate per hour.</param>
        /// <param name="numOfWorkingDays">The number of working days.</param>
        /// <param name="maxHoursPerMonth">The maximum hours per month.</param>
        public CompanyEmpWage(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            this.company = company;
            this.emp_Wage_Per_Hr = emp_Wage_Per_Hr;
            this.working_Days_Per_Month = working_Days_Per_Month;
            this.max_Hrs_Per_Month = max_Hrs_Per_Month;
        }

        /// <summary>
        /// Sets the total emp wage.
        /// </summary>
        /// <param name="totalEmpWage">The total emp wage.</param>
        public void setTotalEmpWage(int total_Emp_Wage)
        {
            this.total_Emp_Wage = total_Emp_Wage;
        }

        //This method returns the string itself
        public string toString()
        {
            return "Total Emp Wage for company: " + this.company + " is: " + this.total_Emp_Wage +"\n";
        }

        /// <summary>
        /// Interface EmployeeWage
        /// </summary>
        public interface IEmployeeWage
        {
            void addCompanyEmpWage(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month);
            int computeEmpWage(CompanyEmpWage companyEmpWage);
            void computeEmpWage();
        }
    }
}
