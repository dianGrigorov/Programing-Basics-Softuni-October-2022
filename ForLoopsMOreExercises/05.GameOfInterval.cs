using System;
using System.ComponentModel;

namespace _05.GameOfInterval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double total = 0;
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int n5 = 0;
            int n6 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num >= 0 && num <= 9)
                {
                    total += num * 0.2;
                    n1++;
                }
                else if (num > 9 && num < 20)
                {
                    total += num * 0.3;
                    n2++;
                }
                else if (num >= 20 && num < 30)
                {
                    total += num * 0.4;
                    n3++;
                }
                else if (num >= 30 && num < 40)
                {
                    total += 50;
                    n4++;
                }
                else if (num >= 40 && num <= 50)
                {
                    total += 100;
                    n5++;
                }
                else
                {
                    total /= 2;
                    n6++;
                }
            }
            double p1 = (double)n1 / n * 100;
            double p2 = (double)n2 / n * 100;
            double p3 = (double)n3 / n * 100;
            double p4 = (double)n4 / n * 100;
            double p5 = (double)n5 / n * 100;
            double p6 = (double)n6 / n * 100;

            Console.WriteLine($"{total:f2}");
            Console.WriteLine($"From 0 to 9: {p1:f2}%");
            Console.WriteLine($"From 10 to 19: {p2:f2}%");
            Console.WriteLine($"From 20 to 29: {p3:f2}%");
            Console.WriteLine($"From 30 to 39: {p4:f2}%");
            Console.WriteLine($"From 40 to 50: {p5:f2}%");
            Console.WriteLine($"Invalid numbers: {p6:f2}%");
        }
    }
}
