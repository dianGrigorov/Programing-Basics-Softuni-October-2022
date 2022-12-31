using System;

namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int count = 0;
            bool isTrue = false;

            for (int i = n1; i <= n2; i++)
            {
                for (int j = n1; j <= +n2; j++)
                {
                    count++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magicNum})");
                        isTrue = true;
                        break;
                    }

                }
                if (isTrue)
                {
                    break;
                }
            }

            if (!isTrue)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}
