using System;

namespace QuotientRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a dividend");
            int dividend=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a divisor");
            int divisor=Convert.ToInt32(Console.ReadLine());
            Quotient.print(dividend, divisor);
        }
    }

}