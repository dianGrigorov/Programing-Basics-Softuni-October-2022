using System;

namespace _03.Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int chrysanthemum = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string hollidayOrNot = Console.ReadLine();
            double chrysanthemumCost = 0;
            double rosesCost = 0;
            double tulipsCost = 0;


            if (season == "Spring" || season == "Summer")
            {
                if (hollidayOrNot == "N")
                {
                    chrysanthemumCost = chrysanthemum * 2;
                    rosesCost = roses * 4.10;
                    tulipsCost = tulips * 2.5;
                }
                else if (hollidayOrNot == "Y")
                {
                    chrysanthemumCost = chrysanthemum * 2 * 1.15;
                    rosesCost = roses * 4.10 * 1.15;
                    tulipsCost = tulips * 2.5 * 1.15;
                }

            }
            else if (season == "Autumn" || season == "Winter")
            {
                if (hollidayOrNot == "N")
                {
                    chrysanthemumCost = chrysanthemum * 3.75;
                    rosesCost = roses * 4.50;
                    tulipsCost = tulips * 4.15;
                }
                else if (hollidayOrNot == "Y")
                {
                    chrysanthemumCost = chrysanthemum * 3.75 * 1.15;
                    rosesCost = roses * 4.50 * 1.15;
                    tulipsCost = tulips * 4.15 * 1.15;
                }
            }
            double bouquet = chrysanthemumCost + rosesCost + tulipsCost ;
            if (season == "Spring" && tulips > 7)
            {
                bouquet *= 0.95;
            }
            else if (season == "Winter" && roses >= 10)
            {
                bouquet *= 0.9;
            }
            if (chrysanthemum + roses + tulips > 20)
            {
                bouquet *= 0.8;
            }
            Console.WriteLine($"{bouquet + 2:f2}");

        }
    }
}
