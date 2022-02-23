using System;

namespace PrintUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of times you want to flip the coin:");
            string number_string = Console.ReadLine();
            int number_int = int.Parse(number_string);
            double head = 0;
            double tail = 0;
            if (number_int > 0)
            {
                for (int i = 1; i <= number_int; i++)
                {
                    Random random = new Random();
                    double flip = random.NextDouble();
                    Console.WriteLine(flip);
                    if (flip<0.5)
                    {
                        head++;
                    }
                    else
                    {
                        tail++;
                    }
                }
                double percentage = (head / number_int) * 100;
                Console.WriteLine("Percentage of heads is {0} and tails is {1}", percentage, 100 - percentage);
            }
            else
            {
                Console.WriteLine("Run again and enter a positive value");
            }
        }
    }

}
