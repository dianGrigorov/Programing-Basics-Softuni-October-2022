using System;
using System.Diagnostics;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameStudent = Console.ReadLine();
            int clas = 1;
            int badGrade = 0;
            double totalGrade = 0;

            while (clas <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                totalGrade += grade;
                clas++;
                if (grade < 4)
                {
                    badGrade++;
                    clas--;
                    if (badGrade > 1)
                    {
                        Console.WriteLine($"{nameStudent} has been excluded at {clas} grade");
                        return;
                    }
                    
                }
                
            }
            double averageGrade = totalGrade / 12;
            Console.WriteLine($"{nameStudent} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
