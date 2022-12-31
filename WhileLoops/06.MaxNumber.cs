using System;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int maxNum = int.MinValue;
            while (num != "Stop")
            {
                int curentNum = int.Parse(num);
                if (maxNum < curentNum)
                {
                    maxNum = curentNum;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
