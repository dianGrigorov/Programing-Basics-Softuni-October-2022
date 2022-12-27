using System;

namespace _05.Vacantion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string type = "";
            double cost = 0;
            if (budget <= 1000)
            {
                type = "Camp";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    cost = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    cost = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                type = "Hut";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    cost = budget * 0.8;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    cost = budget * 0.60;
                }
            }
            else if (budget > 3000)
            {
                type = "Hotel";
                cost = budget * 0.9;
                if (season == "Summer")
                {
                    destination = "Alaska";
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                }
            }
            Console.WriteLine($"{destination} - {type} - {cost:f2}");
        }
    }
}
