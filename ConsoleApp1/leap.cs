using System;
using System.Collections.Generic;
using System.Text;

namespace day5
{
    //
    public class leap
    {
        public static void leapyear() {

            Console.WriteLine("Enter the any year : ");
            int year =Convert.ToInt32( Console.ReadLine());
            if (year%4 == 0)
                Console.WriteLine("year " + year + "   is leap year");
            else
                Console.WriteLine("year " + year + "   is not leap year");
        }
    }
}
