using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int area = lenght * hight *width;
            string comand = Console.ReadLine();
            int totalBoxes = 0;
            while (comand != "Done")
            {
                int boxes = int.Parse(comand);
                totalBoxes += boxes;
                if (area < totalBoxes)
                {
                    Console.WriteLine($"No more free space! You need {totalBoxes - area} Cubic meters more.");
                    return;
                }
                comand = Console.ReadLine();

            }
            if (area >= totalBoxes)
            {
                Console.WriteLine($"{Math.Abs(area - totalBoxes)} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {area - totalBoxes} Cubic meters more.");
            }
        }
    }
}
