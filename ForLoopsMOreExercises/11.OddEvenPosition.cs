using System;

namespace _11.OddEvenPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double evenTotal = 0;
            double evenMax = int.MinValue;
            double evenMin = int.MaxValue;
            double oddTotal = 0;
            double oddMax = int.MinValue;
            double oddMin = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenTotal += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    else if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddTotal += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    else if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }

            }
            
            Console.WriteLine($"OddSum={oddTotal:f2},");
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine($"OddMin=No,");
            }
            else 
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenTotal:f2},");
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            


        }
    }
}
