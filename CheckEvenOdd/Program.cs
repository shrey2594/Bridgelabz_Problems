using System;

namespace CheckEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check even or odd:");
            int number=Convert.ToInt32(Console.ReadLine()); 
            EvenOdd.check(number);
        }
    }

}