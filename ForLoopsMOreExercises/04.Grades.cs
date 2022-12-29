using System;

namespace _04.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int g1 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            int countGrade = 0;
            double average = 0;
            for (int i = 0; i < students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 2 && grade < 3)
                {
                    g1++;
                    average += grade;
                    
                }
                else if (grade >= 3 && grade < 4)
                {
                    g2++;
                    average += grade;
                }
                else if (grade >= 4 && grade < 5 )
                {
                    g3++;
                    average += grade;
                }
                else if (grade >=5)
                {
                    g4++;
                    average += grade;
                }
                countGrade++;
            }
            double p1 = (double)g1 / countGrade * 100;
            double p2 = (double)g2 / countGrade * 100;
            double p3 = (double)g3 / countGrade * 100;
            double p4 = (double)g4 / countGrade * 100;
            average /= countGrade;
            Console.WriteLine($"Top students: {p4:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {p3:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {p2:f2}%");
            Console.WriteLine($"Fail: {p1:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
