using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkPrime
{
    public class CheckPrimeNumber
    {
        public static void check(int number)
        {
            int count = 0;
            int mirror = number;
            while (mirror > 0)
            {
                if ( number % mirror == 0 )
                {
                    count++;
                }
                mirror--;
            }
            if(count>2)
            {
                Console.WriteLine("The number is not prime");
            }
            else
            {
                Console.WriteLine("The number is prime.");
            }
        }
    }
}
