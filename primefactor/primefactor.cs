using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primefactor
{
    public class primefactor
    {
        public static void factorization(int number)
        {
            int j = 1;
            int k = 0;
            int [] prime = new int[number];
            while(j!=number)
            {
                if (number % j == 0)
                {
                    prime[k] = j;
                    k++;
                }
                j++;
            }
            Console.WriteLine("Prime Factors of "+number+" are:"+prime);
        }
    }
}
