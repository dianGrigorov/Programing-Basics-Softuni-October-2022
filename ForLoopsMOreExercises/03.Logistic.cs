using System;

namespace _03.Logistic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargo = int.Parse(Console.ReadLine());
            int sumTons = 0;
            int totalSum = 0;
            int van = 0;
            int truck = 0;
            int trane = 0;
            for (int i = 0; i < cargo; i++)
            {
                int tons = int.Parse(Console.ReadLine());
                if (tons <= 3)
                {
                   totalSum += tons * 200;
                    van += tons;
                }
                else if (tons > 3 && tons <= 11)
                {
                    totalSum += tons * 175;
                    truck += tons;
                }
                else
                {
                    totalSum += tons * 120;
                    trane += tons;
                }
                sumTons += tons;
            }
            double averagePrice = (double)totalSum / sumTons;

            double percentVan = (double)van / sumTons * 100;
            double percentTruck = (double)truck / sumTons * 100;
            double percentTrane = (double)trane / sumTons * 100;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{percentVan:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrane:f2}%");
        }
    }
}
