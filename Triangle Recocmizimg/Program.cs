using System;

namespace TriangleRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The length of the triangle:"); 
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The width of the triangle:");
            double b = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Enter The Height of the triangle:");
            double c = Convert.ToDouble(Console.ReadLine());

            bool isTriangle = CheckPythagorean(a, b, c);

            if (isTriangle)
            {
                Console.WriteLine("The numbers can form a triangle using the Pythagorean theorem.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The numbers cannot form a triangle using the Pythagorean theorem.");
                Console.ResetColor();
            }
        }

        static bool CheckPythagorean(double a, double b, double c)
        {
            double largestSide = Math.Max(a, Math.Max(b, c));

            if (largestSide == a)
            {
                return a * a == b * b + c * c;
            }
            else if (largestSide == b)
            {
                return b * b == a * a + c * c;
            }
            else
            {
                return c * c == a * a + b * b;
            }
        }
    }
}