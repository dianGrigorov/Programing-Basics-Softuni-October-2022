using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                string curentNum = i.ToString();
                int even = 0;
                int odd = 0;
                for (int j = 0; j < curentNum.Length; j++)
                {
                    int curentDigit = int.Parse(curentNum[j].ToString());
                    if (j % 2== 0)
                    {
                        even += curentDigit;
                    }
                    else
                    {
                        odd += curentDigit;
                    }
                }
                if (even == odd)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
