using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    public class Check
    {
        /// <summary>
        /// Checks the number.
        /// </summary>
        public static void CheckTheNumber()
        {
            int n,i,sum,min,max;
            Console.WriteLine("Find the perfect number within a range:");
            Console.WriteLine("Input the start range:");
            min=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the end range:");
            max = Convert.ToInt32(Console.ReadLine());
            for(n=min;n<max;n++)
            {
                i = 1;
                sum = 0;
                while(i<n)
                {
                    if (n %i==0)
                    {
                        sum += i;
                    }
                    i++;
                }
                if(sum==n)
                {
                    Console.WriteLine("{0}", n);
                }
            }
        }
    }
}
