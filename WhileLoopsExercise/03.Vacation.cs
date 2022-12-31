using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double totalMoney = double.Parse(Console.ReadLine());
            int cntDays = 0;
            int totalDays = 0;
            while (vacationPrice > totalMoney)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                totalDays++;
                if (action == "spend")
                {
                    cntDays++;
                    totalMoney -= money;
                    if (totalMoney <0)
                    {
                        totalMoney = 0;
                    }
                    if (cntDays >= 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{totalDays}");
                        return;
                    }
                }
                if (action == "save")
                {
                    totalMoney += money;
                    cntDays = 0;
                }
            }
            Console.WriteLine($"You saved the money for {totalDays} days.");
        }
    }
}
