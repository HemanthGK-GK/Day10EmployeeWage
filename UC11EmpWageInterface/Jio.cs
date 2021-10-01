using System;
using System.Collections.Generic;
using System.Text;

namespace Inter
{
    class Jio: Interface1
    {
        

        int wageperHour = 300;
        int empWage = 0;
        int empHours = 9;

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
