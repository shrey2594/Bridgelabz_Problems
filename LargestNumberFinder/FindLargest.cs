using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumberFinder
{
    public class FindLargest
    {
        public static void Find(int num1, int num2,int num3)
        {
            if(num1>=num2 && num1>=num3)
            {
                Console.WriteLine("Number " + num1 + " is largest of the three numbers");
            }
            else if(num2>=num3)
            {
                Console.WriteLine("Number " + num2 + " is largest of the three numbers");
            }
            else
            {
                Console.WriteLine("Number " + num3 + " is largest of the three numbers");
            }
        }
    }
}
