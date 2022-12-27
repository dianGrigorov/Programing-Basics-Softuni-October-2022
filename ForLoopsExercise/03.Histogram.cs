using System;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;
           
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1++;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4++;
                }
                else if (num >= 800)
                {
                    p5++;
                }

            }
            double percetP1 = Convert.ToDouble(p1) / n * 100;
            double percetP2 = Convert.ToDouble(p2) / n * 100;
            double percetP3 = Convert.ToDouble(p3) / n * 100;
            double percetP4 = Convert.ToDouble(p4) / n * 100;
            double percetP5 = Convert.ToDouble(p5) / n * 100;
            Console.WriteLine($"{percetP1:f2}%");
            Console.WriteLine($"{percetP2:f2}%");
            Console.WriteLine($"{percetP3:f2}%");
            Console.WriteLine($"{percetP4:f2}%");
            Console.WriteLine($"{percetP5:f2}%");
        }
    }
}
