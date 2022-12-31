using System;

namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int cnt = 1;
            bool isBiger = false;
            for (int rows = 1; rows <= num; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    
                    if (cnt > num)
                    {
                        isBiger = true;
                        break;
                    }
                    Console.Write(cnt + " ");
                    cnt++;  
                }
                if (isBiger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
