using System;

namespace UC9EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Neww jio = new Neww("Jio", 50, 25, 100);
            Neww airtel = new Neww("Airtel", 40, 23, 98);
            jio.getEmpWage();
            Console.WriteLine(jio.toString());
            airtel.getEmpWage();
            Console.WriteLine(airtel.toString());


        }
    }
}
