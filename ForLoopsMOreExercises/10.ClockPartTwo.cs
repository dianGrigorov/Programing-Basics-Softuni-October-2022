using System;

namespace _10.ClockPartTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    for (int g = 0; g < 60; g++)
                    {
                        Console.Write(i);
                        Console.Write(" : ");
                        Console.Write(j);
                        Console.Write(" : ");
                        Console.WriteLine(g);
                    }
                }
            }
        }
    }
}
