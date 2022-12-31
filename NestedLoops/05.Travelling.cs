using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination;
            

            while ((destination = Console.ReadLine()) != "End")
            {
                double tripPrice = double.Parse(Console.ReadLine());
                double total = 0;

                while (total < tripPrice)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    total += savedMoney;

                }
                Console.WriteLine($"Going to {destination}!");
               
               
            }
        }
    }
}
