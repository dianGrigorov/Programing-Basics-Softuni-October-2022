using System;

namespace _02Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string passwordUser = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != passwordUser )
            {
               input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {userName}");
        }
    }
}
