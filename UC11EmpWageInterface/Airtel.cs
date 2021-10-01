using System;
using System.Collections.Generic;
using System.Text;

namespace Inter
{
    class Airtel: Interface1
    {
        int wageperHour = 200;
        int empWage = 0;
        int empHours = 8;

        public void getCompanyName(string cname)
        {
            Console.WriteLine("Company Name : " + cname);
        }

        public void getWage()
        {
            empWage = empHours * wageperHour;
            Console.WriteLine("EmployeeWage is : " + empWage);
        }
    }
}

