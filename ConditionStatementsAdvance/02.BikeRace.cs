using System;

namespace _02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numJuniar = int.Parse(Console.ReadLine());
            int numSenior = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();
            double totalSum = 0;
            if (trace == "trail")
            {
                totalSum += numJuniar * 5.5;
                totalSum += numSenior * 7.0;
            }
            else if (trace == "cross-country")
            {
                totalSum += numJuniar * 8;
                totalSum += numSenior * 9.5;
                if (numJuniar + numSenior >= 50)
                {
                    totalSum -= totalSum * 0.25;
                }
            }
            else if (trace == "downhill")
            {
                totalSum += numJuniar * 12.25;
                totalSum += numSenior * 13.75;
            }
            else if (trace == "road")
            {
                totalSum += numJuniar * 20;
                totalSum += numSenior * 21.5;
            }
            totalSum -= totalSum * 0.05;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
