using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    //Interface
    public interface IComputeEmpWage
    {
        void AddCompanyEmpWage(string companyName, int maxWorkingDay, int maxWorkingHrs, int empRate);
        void ComputeEmpWage();
    }
    public class EmpBuilderArray : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWaeList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpBuilderArray()
        {
            this.companyEmpWaeList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWaeList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }
        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWaeList)
            {
                companyEmpWage.setTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                //Computation
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Employee wage for day {0} for {1} Hrs", totalWorkingDays, empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;

        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }
    }
}