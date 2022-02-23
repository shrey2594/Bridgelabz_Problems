using System;

namespace Harmonic_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the N value:");
            int N=Convert.ToInt32(Console.ReadLine());
            if (N!=0)
            {
                double value = Harmonic_Number.result(N);
                Console.WriteLine("Result is:" + value);
            }
            else 
            {
                Console.WriteLine("Enter non zero value and run again...");
            }
            
        }
    }

}