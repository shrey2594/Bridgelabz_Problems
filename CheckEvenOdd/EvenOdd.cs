using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEvenOdd
{
    public static class EvenOdd
    {
        public static void check(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is even.", number);
            }
            else
            {
                Console.WriteLine("{0} is odd.", number);
            }
        }
    }
}
