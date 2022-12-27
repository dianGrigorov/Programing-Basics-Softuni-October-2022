using System;
using System.IO;

namespace _09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                left += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
               right += num;
            }
            if (left == right)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                int diference = Math.Abs(left - right);
                Console.WriteLine($"No, diff = {diference}");
            }
        }
    }
}
