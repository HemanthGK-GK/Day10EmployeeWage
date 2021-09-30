using System;
using System.Collections.Generic;
using System.Text;

namespace UC10MultipleCompanies
{
    class CompanyWage
    {
       public string cname;
       public int empRate;
       public int totalDays;
       public int totalHours;
       public int totalWage = 0;

        public CompanyWage(string cname, int empRate, int totalDays, int totalHours)
        {
            this.cname = cname;
            this.empRate = empRate;
            this.totalDays = totalDays;
            this.totalHours = totalHours;
        }
        public void setTotalEmpWage(int totalWage)
        {
            this.totalWage = totalWage;
        }
        public string toString()
        {
            return "Total Employee Wage for company " + this.cname + " is : " + this.totalWage;
        }
    }
}
