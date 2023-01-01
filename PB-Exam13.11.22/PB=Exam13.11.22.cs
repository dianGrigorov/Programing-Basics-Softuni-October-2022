using System;

namespace PB_Exam13._11._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double cpuPrice = double.Parse(Console.ReadLine());
           double gpuPrice = double.Parse(Console.ReadLine());
           double ramPrice = double.Parse(Console.ReadLine());
           int peaceRam = int.Parse(Console.ReadLine());
           double discount = double.Parse(Console.ReadLine());
            
            double totalDiscount = (cpuPrice + gpuPrice) * discount ;
            double totalRam = ramPrice * peaceRam;
            double totalCost =cpuPrice + gpuPrice + totalRam - totalDiscount;
            double convertToBgn = totalCost * 1.57;
            Console.WriteLine($"Money needed - {convertToBgn:f2} leva.");
        }
    }
}
