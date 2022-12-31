using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            string presentation;
            int presentationCnt = 0;
            double averageSuccess = 0;
            while ((presentation = Console.ReadLine()) != "Finish")
            {
                presentationCnt++;
                double totalEvaluation = 0;
                for (int i = 0; i < judges; i++)
                {
                    double evaluation = double.Parse(Console.ReadLine());
                    totalEvaluation += evaluation;
                }
                double averageEvaluation = totalEvaluation / judges;
                averageSuccess += averageEvaluation;
                Console.WriteLine($"{presentation} - {averageEvaluation:f2}.");
            }

            Console.WriteLine($"Student's final assessment is {(averageSuccess / presentationCnt):f2}.");
        }
    }
}
