using System;
using System.Collections.Generic;
using System.Text;

namespace day5
{
    class uc6reminderquotient

    {
        public static void reminderquetiont() {
            int dividend = 50, divisor = 8;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

           
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
