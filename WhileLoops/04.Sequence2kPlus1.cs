using System;

namespace _04.Sequence2kPlus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int output = 1;
            while (output <= input)
            {
                Console.WriteLine(output);
                
                output = output * 2 + 1;
              

            }
        }
    }
}
