using System;
using System.Collections.Generic;
using System.Text;

namespace UC10MultipleCompanies
{
    class Neww
    {
       public const int fullTime = 2;
       public const int partTime = 1;

       private  int numOfCompany = 0;
       private CompanyWage[] companyArray;

        public Neww()
        {
            this.companyArray = new CompanyWage[2];
        }
        public void getCompanyWage(string cname, int empRate, int totalDays, int totalHours)
        {
            companyArray[this.numOfCompany] = new CompanyWage(cname, empRate, totalDays, totalHours);
            numOfCompany++;
        }

        public void computeWage()
        {
            for (int i=0;i<numOfCompany;i++)
            {
                companyArray[i].setTotalEmpWage(this.computeWage(this.companyArray[i]));
                Console.WriteLine(this.companyArray[i].toString());
            }
        }
        public int computeWage(CompanyWage companyWage)
        {

            int hours = 0;
            int workingDays = 0;
            int workingHours = 0;
            while (workingDays <= companyWage.totalDays && workingHours <= companyWage.totalHours)
            {
                workingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case fullTime:
                        hours = 12;
                        break;
                    case partTime:
                        hours = 8;
                        break;
                    default:
                        hours = 0;
                        break;
                }
                workingHours = workingHours + hours;
                Console.WriteLine("Days" + workingDays + "Hours : " + workingHours);
            }
            return workingHours = companyWage.empRate;
        }
    }
}
