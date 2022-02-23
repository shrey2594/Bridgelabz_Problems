using System;

namespace LargestNumberFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1:");
            int number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3:");
            int number3 = Convert.ToInt32(Console.ReadLine());
            FindLargest.Find(number1,number2, number3);
        }
    }

}