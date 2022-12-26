using System;

namespace _01.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double tickets = 0;

            double transport = 0;

            if (people >= 1 && people <= 4)
            {
                transport = budget * 0.75;
            }
            else if (people > 4 && people <= 9)
            {
                transport = budget * 0.6;
            }
            else if (people > 9 && people <= 24)
            {
                transport = budget * 0.5;
            }
            else if (people > 24 && people <= 49)
            {
                transport = budget * 0.4;
            }
            else if (people > 49)
            {
                transport = budget * 0.25;
            }
            
            switch (category)
            {
                case "VIP":
                    tickets = 499.99 * people;
                    break;
                case "Normal":
                    tickets = 249.99 * people;
                    break;
            }
            double totaMoney = budget - transport - tickets;
            if (budget >= totaMoney && totaMoney > 0)
            {

                Console.WriteLine($"Yes! You have {totaMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(totaMoney):f2} leva.");
            }

        }
    }
}
