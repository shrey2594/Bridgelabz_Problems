using System;

namespace PrintUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year:");
            string year_s=Console.ReadLine();
            int year_t=int.Parse(year_s);
            if (year_t>999)
            {
                if (year_t%400==0)
                {
                    Console.WriteLine("{0} is a leap year.", year_t);
                }
                else if (year_t%100==0)
                {
                   Console.WriteLine("{0} is not a leap year.", year_t);
                }
                else if (year_t%4==0)
                {
                    Console.WriteLine("{0} is a leap year.", year_t);
                }
                else { Console.WriteLine("{0} is not a leap year.", year_t); }
            }
            else
            {
                Console.WriteLine("Enter year above 999 and run again.");
            }
        }
    }

}
