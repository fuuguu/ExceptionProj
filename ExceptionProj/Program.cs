using System;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coefficients of the quadratic equation ax^2+bx+c=0:");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());

            try
            {
                double delta = Math.Pow(b, 2) - 4 * a * c;

                if (delta < 0)
                {
                    throw new Exception("The equation has no real roots.");
                }

                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("The roots of the equation are:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}