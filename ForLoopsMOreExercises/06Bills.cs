using System;

namespace _06Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double totalElectrisity = 0;
            double totalWater=0;
            double totalInternet = 0;
            double totalOther = 0;
            int internet = 15;
            int water = 20;
            for (int i = 0; i < months; i++)
            {
                double electricBill = double.Parse(Console.ReadLine()); 
                totalElectrisity += electricBill;
                totalWater += water;
                totalInternet += internet;
                totalOther += (electricBill + water + internet) * 1.2;

            }
            double average = (totalElectrisity + totalWater + totalInternet + totalOther) / months;
            Console.WriteLine($"Electricity: {totalElectrisity:f2} lv");
            Console.WriteLine($"Water: {totalWater:f2} lv");
            Console.WriteLine($"Internet: {totalInternet:f2} lv");
            Console.WriteLine($"Other: {totalOther:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");

        }
    }
}
