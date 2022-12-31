using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num;
            int primeNumber = 0;
            int nonPrimeNUmber = 0;

            while ((num = Console.ReadLine()) != "stop")
            {
                int curentNum = int.Parse(num);
                if (curentNum < 0 )
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                bool isPrime = true;
                for (int div = 2; div <= Math.Sqrt(curentNum); div++)
                {
                    if (curentNum % div == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumber += curentNum;
                }
                else
                {
                    nonPrimeNUmber += curentNum;
                }
                
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeNumber}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeNUmber}");
        }
    }
}
