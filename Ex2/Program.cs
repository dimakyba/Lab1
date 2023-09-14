using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            // Console.Write("Введіть х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Pow(2, x) * x * Math.Cos(x) + 1;
            Console.WriteLine(y);

            Console.ReadKey();
        }
    }
}


