using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie;
            int student = 0;
            int standart = 0;
            int kids = 0;
            int totalTicked = 0;
            while ((movie = Console.ReadLine()) != "Finish")
            {
                int totalSeats = int.Parse(Console.ReadLine());
                string typeOfTicket;
                int occupiedSeets = 0;
                while ((typeOfTicket = Console.ReadLine()) != "End")
                {
                   occupiedSeets++;
                    totalTicked++;
                    if (typeOfTicket == "student")
                    {
                        student++;
                    }
                    else if (typeOfTicket == "standard")
                    {
                        standart++;
                    }
                    else if (typeOfTicket == "kid")
                    {
                        kids++;
                    }
                    if (occupiedSeets >= totalSeats)
                    {
                        break;
                    }
                }
                double seatsPersentage = (double)occupiedSeets / totalSeats * 100;
                Console.WriteLine($"{movie} - {seatsPersentage:f2}% full.");
            }
            double studentPercentage = (double)student / totalTicked * 100;
            double standartPercentage = (double)standart / totalTicked * 100;
            double kidsPercentage = (double)kids / totalTicked * 100;
            Console.WriteLine($"Total tickets: {totalTicked}");
            Console.WriteLine($"{studentPercentage:f2}% student tickets.");
            Console.WriteLine($"{standartPercentage:f2}% standard tickets.");
            Console.WriteLine($"{kidsPercentage:f2}% kids tickets.");
        }
    }
}
