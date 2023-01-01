using System;
using System.Runtime.Intrinsics.X86;

namespace _06.Substitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int cnt = 0;

            //•	Първата цифра на първото число е в интервала от цифрата K до 8, включително.
            //•	Втората цифра на първото число е в интервала от 9 до L, включително.
            //•	Първата цифра на второто число е в интервала от цифрата M до 8, включително.
            //•	Втората цифра на второто число е в интервала от 9 до N, включително.
            for (int i = n1; i <= 8; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 9; j >= n2; j--)
                    {
                        if (j % 2 != 0)
                        {
                            for (int k = n3; k <= 8; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    for (int l = 9; l >= n4; l--)
                                    {
                                        if (l % 2 != 0)
                                        {
                                            if (i == k && j == l)
                                            {
                                                Console.WriteLine("Cannot change the same player.");

                                            }
                                            else
                                            {
                                                Console.WriteLine($"{i}{j} - {k}{l}");
                                                cnt++;
                                                if (cnt >= 6)
                                                {
                                                    return;
                                                }

                                            }
                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }


        }
    }
}
