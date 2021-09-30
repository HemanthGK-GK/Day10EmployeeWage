using System;

namespace UC10MultipleCompanies
{
    class Program
    {
        static void Main(string[] args)
        {
            Neww obj = new Neww();
            obj.getCompanyWage("jio", 20, 10, 100);
            obj.getCompanyWage("Airtel", 15, 20, 100);
            obj.computeWage();
        }
    }
}
