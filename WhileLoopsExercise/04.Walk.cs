using System;

namespace _04.Walk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stepsPerDay = Console.ReadLine();
            int totalSteps = 0;
            int goal = 10000;
            while (stepsPerDay != "Going home")
            {
                int steps = int.Parse(stepsPerDay);
                totalSteps += steps;
                if (totalSteps >= goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - goal} steps over the goal!");
                    return;
                }
                stepsPerDay = Console.ReadLine();   
            }
            if (stepsPerDay == "Going home")
            {
                int steps = int.Parse(Console.ReadLine());
                totalSteps += steps;
                if (totalSteps >= goal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{totalSteps - goal} steps over the goal!");
                    return;
                }
                else
                {
                    Console.WriteLine($"{goal - totalSteps} more steps to reach goal.");
                }
                
            }
            

        }
    }
}
