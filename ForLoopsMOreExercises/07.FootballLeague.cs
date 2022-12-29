using System;

namespace _07.FootballLeague
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int numFans = int.Parse(Console.ReadLine());
            int groupA = 0;
            int groupB = 0;
            int groupV = 0;
            int groupG = 0;
            
            for (int i = 1; i <= numFans; i++)
            {
                string group = Console.ReadLine();
                switch (group)
                {
                    case "A":
                        groupA++;
                        break;
                    case "B":
                        groupB++;
                        break;
                    case "V":
                        groupV++;
                        break;
                    case "G":
                        groupG++;
                        break;
                }
               
            }

            double percentA = (double)groupA / numFans * 100;
            double percentB = (double)groupB / numFans * 100;
            double percentV = (double)groupV / numFans * 100;
            double percentG = (double)groupG / numFans * 100;
            double totalPercent = (double)numFans / capacity * 100;

            Console.WriteLine($"{percentA:f2}%");
            Console.WriteLine($"{percentB:f2}%");
            Console.WriteLine($"{percentV:f2}%");
            Console.WriteLine($"{percentG:f2}%");
            Console.WriteLine($"{totalPercent:f2}%");

        }
    }
}
