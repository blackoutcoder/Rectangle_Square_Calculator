using System;

namespace Rectangle_Square_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RectangleSquareFinder finder = new RectangleSquareFinder();
            finder.Reader();
            finder.Calculator();
            finder.Printer();
        }

        public class RectangleSquareFinder
        {
            int a, b, square;
            public void Reader()
            {
                Console.WriteLine("Rectangle square calculator...");
                
                Console.WriteLine("Enter A side and press Enter...");
                a = Convert.ToInt32(Console.ReadLine());
                while(a <= 0)
                {
                    Console.WriteLine("Number must be POSITIVE...");
                    Console.WriteLine("Enter A side and press Enter...");
                    a = Convert.ToInt32(Console.ReadLine());
                }
                
                Console.WriteLine("Enter B side and press Enter...");
                b = Convert.ToInt32(Console.ReadLine());
                while (b <= 0)
                {
                    Console.WriteLine("Number must be POSITIVE...");
                    Console.WriteLine("Enter A side and press Enter...");
                    b = Convert.ToInt32(Console.ReadLine());
                }

            }

            public void Calculator()
            {
                square = a * b;
            }

            public void Printer()
            {
                Console.Clear();
                Console.WriteLine($"Rectange side A = {a}, side B = {b}, SQUARE = {square}");
                Console.ReadLine();
            }
        }
    }
}
