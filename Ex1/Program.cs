using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть час: ");
            double t_time = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть швидкість");
            double v_speed = Convert.ToDouble(Console.ReadLine());
            double s_way = t_time * v_speed;
            Console.WriteLine($"За {t_time} годин, рухаючись з постійною швидкість{v_speed} км/год автомобіль проїде {s_way}км");
            
            Console.ReadKey();
        }
    }
}