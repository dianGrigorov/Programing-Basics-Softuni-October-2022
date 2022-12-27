using System;

namespace _08.TenisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numTour = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int totalPoints = 0;
            int winTour = 0;
            for (int i = 1; i <= numTour; i++)
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    totalPoints += 2000;
                    winTour++;
                }
                else if (stage == "F")
                {
                    totalPoints += 1200;
                }
                else if (stage == "SF")
                {
                    totalPoints += 720;
                }
            }
            double winPercent = ((double)winTour / numTour) * 100;
            double averagePoints = Math.Floor((double)totalPoints / numTour);
            Console.WriteLine($"Final points: {totalPoints + startPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{winPercent:f2}%");
        }
    }
}
