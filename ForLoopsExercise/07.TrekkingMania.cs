using System;

namespace _07TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int totalPeople = 0;
            int g1 = 0;
            int g2= 0;
            int g3= 0;
            int g4= 0;
            int g5= 0;
            for (int i = 0; i < groups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                totalPeople += people;
                if (people <=5)
                {
                    g1 += people;
                }
                else if (people > 5 && people <=12)
                {
                    g2 += people;
                }
                else if (people > 12 && people <= 25)
                {
                    g3 += people;
                }
                else if (people > 25 && people <= 40)
                {
                    g4 += people;
                }
                else if (people > 40)
                {
                    g5 += people;
                }
            }
            double p1 = ((double)g1 / totalPeople) * 100;
            double p2 = ((double)g2 / totalPeople) * 100;
            double p3 = ((double)g3 / totalPeople) * 100;
            double p4 = ((double)g4 / totalPeople) * 100;
            double p5 = ((double)g5 / totalPeople) * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
           
        }
    }
}
