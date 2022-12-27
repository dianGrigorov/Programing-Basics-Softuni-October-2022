using System;

namespace _04.RentACar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string classCar = "";
            double rentPrice = 0;
            string type = "";

            if (budget <= 100)
            {
                classCar = "Economy class";
                if (season == "Summer")
                {
                    rentPrice = budget * 0.35;
                    type = "Cabrio";
                }
                else if (season == "Winter")
                {
                    rentPrice = budget * 0.65;
                    type = "Jeep";
                }
            }
            else if (budget >100 && budget <= 500)
            {
                classCar = "Compact class";
                if (season == "Summer")
                {
                    rentPrice = budget * 0.45;
                    type = "Cabrio";
                }
                else if (season == "Winter")
                {
                    rentPrice = budget * 0.80;
                    type = "Jeep";
                }
            }
            else if (budget > 500)
            {
                classCar = "Luxury class";
                if (season == "Summer"  || season == "Winter")
                {
                    rentPrice = budget * 0.9;
                    type = "Jeep";
                }
            }
            Console.WriteLine($"{classCar}");
            Console.WriteLine($"{type} - {rentPrice:f2}");
        }
    }
}
