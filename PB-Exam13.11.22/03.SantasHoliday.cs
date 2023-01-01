using System;

namespace _03.SantasHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            double totalCost = 0;
            int nights = days - 1;
            if (typeOfRoom == "room for one person")
            {
                totalCost = nights * 18.00;
            }
            else if (typeOfRoom == "apartment")
            {
                totalCost = nights * 25.00;
                if (days < 10)
                {
                    totalCost *= 0.7;
                }
                else if (days >= 10 && days <= 15)
                {
                    totalCost *= 0.65;
                }
                else if (days > 15)
                {
                    totalCost *= 0.5;
                }
            }
            else if (typeOfRoom == "president apartment")
            {
                totalCost = nights * 35.00;
                if (days < 10)
                {
                    totalCost *= 0.9;
                }
                else if (days >= 10 && days <= 15)
                {
                    totalCost *= 0.85;
                }
                else if (days > 15)
                {
                    totalCost *= 0.8;
                }
            }

            if (rating == "positive")
            {
                totalCost *= 1.25;
            }
            else if (rating == "negative")
            {
                totalCost *= 0.9;
            }
            Console.WriteLine($"{totalCost:f2}");
        }
    }
}
