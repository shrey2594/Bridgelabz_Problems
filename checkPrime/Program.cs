using System;

namespace checkPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is prime or not:");
            int number=Convert.ToInt32(Console.ReadLine());
            CheckPrimeNumber.check(number);
        }
    }

}