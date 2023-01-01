using System;

namespace _05.ExcursionSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seaPack = int.Parse(Console.ReadLine());
            int mountainPack = int.Parse(Console.ReadLine());
            int profit = 0;
            string type;
            bool noMore = false;
            while ((type = Console.ReadLine()) != "Stop")
            {
                if (type == "sea")
                {
                    if (seaPack <= 0)
                    {
                        continue;
                    }
                    profit += 680;
                    seaPack--;

                }
                else if (type == "mountain")
                {
                    if (mountainPack <= 0)
                    {
                        continue;
                    }
                    profit += 499;
                    mountainPack--;

                }
                if (seaPack < 0 && mountainPack < 0)
                {

                }
                if (seaPack <= 0 && mountainPack <= 0)
                {
                    break;
                }
            }
            if (seaPack <= 0 && mountainPack <= 0)
            {
                Console.WriteLine(" Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
