using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("введите k");
                int k = int.Parse(Console.ReadLine());
                double S = 0;
                for (int i = 1; i <=k; i++)
                {
                    if (i==3) continue;
                    S += Math.Pow(-1, i) / (Math.Pow(i - 3, 2));
                }
                double P = 1;
                int j = 1;
                for (int n =j ; n <=2*k; n++)
                {
                    if (n==8||n==-2) continue;
                    P *= Math.Pow(n, 3) - 8 / n + 2;
                }
                Console.WriteLine($"A={P * S:F2}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
