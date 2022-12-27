using System;

namespace _04_CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrise = int.Parse(Console.ReadLine());
            int money = 0;
            int moneyUpdate = 0;
            int toys = 0;
            for (int i =1 ; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += i / 2 * 10;
                    money--;
                   
                }
                else
                {
                    toys++;
                }
            }
            toyPrise *= toys;
            double totalMoney = money + toyPrise;
            if (totalMoney >= washingMachine)
            {
                Console.WriteLine($"Yes! {totalMoney - washingMachine:f2}");
            }
            else
            {
                double diff = Math.Abs(totalMoney - washingMachine);
                Console.WriteLine($"No! {diff:f2}");
            }

        }
    }
}
