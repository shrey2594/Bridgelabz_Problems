using System;

namespace power2    
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value between 0 and 31:");
            int pow=Convert.ToInt32(Console.ReadLine());
            if (pow>=0 && pow<31)
            {
                power2.power_calculator_2(pow);
            } 
            else
            {
                Console.WriteLine("Run again with a value between 0 and 31.");
            }
        }
    }

}