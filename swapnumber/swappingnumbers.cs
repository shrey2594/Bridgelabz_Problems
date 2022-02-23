using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapnumber
{
    public class swappingnumbers
    {
        public static void SwapTwoNumbers()
        {
            int a = 4;
            int b = 5;
            Console.WriteLine("Number a before swapping:" + a);
            Console.WriteLine("Number b before swapping:" + b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("Number a after swapping:" + a);
            Console.WriteLine("Number b after swapping:" + b);
        }
    }
}
