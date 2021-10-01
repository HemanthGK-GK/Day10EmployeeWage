using System;

namespace Inter
{
    class Program
    {
        static void Main(string[] args)
        {
            Jio jio = new Jio();
            Airtel air = new Airtel();
            jio.getWage();
            jio.getCompanyName("Jio");
            air.getWage();
            air.getCompanyName("Airtel");

        }
    }
}
