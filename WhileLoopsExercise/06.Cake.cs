using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int cakeSize = lenght * width;
            string piece;
            int totalPieses = 0;
            while ((piece = Console.ReadLine()) != "STOP")
            {
                int inputPieces = int.Parse(piece);
                totalPieses += inputPieces;
                if (cakeSize <= totalPieses )
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize - totalPieses)} pieces more.");
                    return;
                }
                
            }
            Console.WriteLine($"{cakeSize - totalPieses} pieces are left.");
        }
    }
}
