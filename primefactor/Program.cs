using System;
namespace primefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to check prime factor :");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(N);
            primefactor.factorization(N);
        }
    }

}