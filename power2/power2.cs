using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power2
{
    public class power2
    {
        public static void power_calculator_2(int value)
        {
            for (int i = 0; i <= value; i++)
            {
                Console.WriteLine("2*"+i+"="+Math.Pow(2,i));
            }
        }
    }
}
