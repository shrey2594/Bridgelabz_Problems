using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotientRemainder
{
    public class Quotient
    {
        public static void print(int dividend,int divisor)
        {
            Console.WriteLine("The quotient is:" + (dividend / divisor));
            Console.WriteLine("The remainder is:"+(dividend % divisor)); 
        }
    }
}
