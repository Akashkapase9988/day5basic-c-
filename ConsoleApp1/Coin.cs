using System;
using System.Collections.Generic;
using System.Text;

namespace day5
{
    public class Coin
    {
        public static void flipcoin()
        {
            
            int head = 0;
            int tell = 0;
            // Type your username and press enter
            Console.WriteLine("Enter how many time coin will flip:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            int count =Convert.ToInt32( Console.ReadLine());

            for (int i = 0; i <= count; i++)
            {
                Random random = new Random();

                int check = random.Next(0, 2);
                if (check <= 0.5)
                {
                    Console.WriteLine("head ");
                    ++tell;
                }
                else
                {
                    Console.WriteLine("tail");
                    ++head;
                }
            }
            Console.WriteLine("count of head and tell is respectively : " + head + "  " + tell);
            float phead = (head / count) * 100;
            float ptell = (tell / count) * 100;
            Console.WriteLine("percentage of head and tell is respectively : " + phead + "  " + ptell);            
        }
        //
    }
}
