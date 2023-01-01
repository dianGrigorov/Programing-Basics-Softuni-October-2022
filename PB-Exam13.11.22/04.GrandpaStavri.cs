using System;

namespace _04.GrandpaStavri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalShnaps = 0;
            double totalDegreeses = 0;

            for (int i = 0; i < days; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());
                totalShnaps += quantity;
                totalDegreeses += degrees * quantity;
            }
            double averageDegreeses = totalDegreeses / totalShnaps;

            Console.WriteLine($"Liter: {totalShnaps:f2}");
            Console.WriteLine($"Degrees: {averageDegreeses:f2}");
            if (averageDegreeses < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (averageDegreeses >= 38 && averageDegreeses <= 42)
            {
                Console.WriteLine("Super!");
            }
            else if (averageDegreeses > 42)
            {
                Console.WriteLine($"Dilution with distilled water!");
            }
        }
    }
}
