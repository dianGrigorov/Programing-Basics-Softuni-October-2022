using System;

namespace _01.BackToThePast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inheritance = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int ivanYear = 18;
            double moneyLeft = 0;

            for (int i = 1800; i <= year; i++)
            {
                
                if (i % 2 == 0)
                {
                    inheritance -= 12000;
                }
                else
                {
                    inheritance -= (12000 + 50 * ivanYear);
                }
                ivanYear++;
            }
            
            if (inheritance >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(inheritance):f2} dollars to survive.");
            }
        }
    }
}
