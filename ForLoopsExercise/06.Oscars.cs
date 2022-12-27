using System;

namespace _06Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actоr = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int refers = int.Parse(Console.ReadLine());
           
            
            for (int i = 0; i < refers; i++)
            {
                string referName = Console.ReadLine();
                double refPoints = double.Parse(Console.ReadLine());

                points += referName.Length * refPoints / 2 ;
                if (points > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actоr} got a nominee for leading role with {points:f1}!");
                    return;
                }
            }
            Console.WriteLine($"Sorry, {actоr} you need {1250.5 - points:f1} more!");

        }
    }
}
