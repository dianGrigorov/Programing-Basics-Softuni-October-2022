using System;

namespace _02.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctor = 7;
            int unrevew = 0;
            int revew = 0;
            
            for (int i = 1; i <= period; i++)
            {
                
                int patient = int.Parse(Console.ReadLine());
              
                if (unrevew > revew && i % 3 == 0)
                {
                    doctor++;
                }
                if (patient <= doctor)
                {
                    revew += patient;
                }
                else
                {
                    revew += doctor;
                    unrevew += patient - doctor;
                   
                }
               

            }
            Console.WriteLine($"Treated patients: {revew}.");
            Console.WriteLine($"Untreated patients: {unrevew}.");
        }
    }
}
