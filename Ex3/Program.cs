using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            bool isInsideEllipse = ((x * x / 9 + y * y) <= 1 && y >= 0);
            bool isInsideRectangle = (x >= -1 && x <= 1 && y >= -2 && y <= 0);

            if (isInsideEllipse || isInsideRectangle)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadKey();
        }
    }
}
