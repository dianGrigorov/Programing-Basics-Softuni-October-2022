using System;

namespace _06.MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int minNum = int.MaxValue;
            while (num != "Stop")
            {
                int curentNum = int.Parse(num);
                if (minNum > curentNum)
                {
                    minNum = curentNum;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
