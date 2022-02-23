using System;

namespace PrintUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username:");
            string UserName = Console.ReadLine();
            if (UserName.Length>=3)
            {
                Console.WriteLine("Hi, username:"+UserName+" ,have a good day.");
            }
            else
            {
                Console.WriteLine("Enter username again , with more than 3 characters.");
            }
        }
    }

}

