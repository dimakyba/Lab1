using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Pow(2, x) * x * Math.Cos(x) + 1;
            Console.WriteLine($"y = {y}");

            Console.ReadKey();
        }
    }
}


