using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double symm = 0;
            Console.WriteLine("Введите число n:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i<=n;i++)
            {
                symm = symm + (1 + (1 / Math.Pow(i, 2)));
            }
            Console.WriteLine("Сумма равна = " + symm);
        }
    }
}
