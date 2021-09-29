using System;
using System.Collections.Generic;
using System.Text;

namespace UC9EmpWage
{
    public class Neww
    {
        const int fullTime = 2;
        const int partTime = 1;

        string cname;
        int empRate;
        int totalDays;
        int totalHours;
        int totalWage = 0;
        
        public Neww(string cname, int empRate, int totalDays, int totalHours)
        {
            this.cname = cname;
            this.empRate = empRate;
            this.totalDays = totalDays;
            this.totalHours = totalHours;
        }
         public void getEmpWage()
        {
            int hours = 0; 
            int workingDays = 0;
            int workingHours = 0;
            while (workingDays <= this.totalDays && workingHours <= this.totalHours)
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

            }
            
            totalWage += workingHours*this.empRate;
            Console.WriteLine("Totalday :" + workingDays);
            Console.WriteLine("TotalHours:" + workingHours);
            Console.WriteLine("Employee Wage new:" + totalWage);
           
        }
        public string toString()
        {
            return "Total EmployeeWage For Company : " + this.cname + "is" + this.totalWage;
        }
    }
}
