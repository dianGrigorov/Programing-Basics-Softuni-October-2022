using System;

namespace _02.FootBallKit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tShirt = double.Parse(Console.ReadLine());
            double priceToWin = double.Parse(Console.ReadLine());

            double shorts = tShirt * 0.75;
            double socks = shorts * 0.20;
            double shouse = (shorts + tShirt) * 2;

            double totalPay = (shorts + socks + shouse + tShirt) * 0.85;

            if (priceToWin <= totalPay)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {totalPay:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {priceToWin - totalPay:f2} lv. more.");
            }

        }
    }
}
