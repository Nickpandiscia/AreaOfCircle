using System;

namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int div = a / b;
            int mod = a % b;
            if(a == 17 && b == 4)
                Console.WriteLine($"{a}/{b} is {b} reaminder {mod}.");

            Console.WriteLine("What is the radius of a circle?");
            var radius = double.Parse(Console.ReadLine());
            var pi = Math.PI;
            var area = pi * (radius * radius);
            Console.WriteLine($"The radius of the circle is {radius} with an area of{area}.");
        }
        public static double theArea(double radius)
        {
            return  Math.PI * (radius * radius);
        }
    }
}