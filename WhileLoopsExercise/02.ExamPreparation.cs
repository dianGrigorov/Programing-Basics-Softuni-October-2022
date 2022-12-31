using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrade = int.Parse(Console.ReadLine());
            string task;
            int badGradeGiven = 0;
            int taskCnt = 0;
            double gradeCnt = 0;
            string lastProblem = "";
            while ((task = Console.ReadLine()) != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badGradeGiven++;
                    if (badGradeGiven >= badGrade)
                    {
                        Console.WriteLine($"You need a break, {badGradeGiven} poor grades.");
                        return;
                    }
                }
                taskCnt++;
                gradeCnt += grade;
                lastProblem = task;
            }
            double average = gradeCnt / taskCnt;
            Console.WriteLine($"Average score: {average:f2}");
            Console.WriteLine($"Number of problems: {taskCnt}");
            Console.WriteLine($"Last problem: {lastProblem}");      
                  

        }
    }
}
