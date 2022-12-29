using System;

namespace _08.EqualPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int score1 = 0;
            int score2 = 0;
            for (int i = 0; i < num; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                if(i % 2==0)
                {
                    score1 = a + b; 
                }
                else
                {
                    score2 = a + b;
                }
                if (i == 0)
                {
                    score2 = score1;
                }

            }
            if (score1 == score2)
            {
                Console.WriteLine($"Yes, value={score1}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={Math.Abs(score1 - score2)}");
            }

        }
    }
}
