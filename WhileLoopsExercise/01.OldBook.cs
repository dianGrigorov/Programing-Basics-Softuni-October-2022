using System;

namespace WhileLoopExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string curentBook = Console.ReadLine();
            int cnt = 0;
            while (curentBook != "No More Books")
            {
                if (curentBook == book)
                {
                    Console.WriteLine($"You checked {cnt} books and found it.");
                    return;
                }
                cnt++;
                curentBook = Console.ReadLine();

            }
            Console.WriteLine($"The book you search is not here!");
            Console.WriteLine($"You checked {cnt} books.");
        }
    }
}
