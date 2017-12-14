using System;

namespace LetterLWrong
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("1 = Rectangle, 2 = Square");

            var userDecition = Console.ReadLine();
            var rectangle = userDecition == "1" ? new Rectangle(10, 10) : new Square(10);
            ValidateLiskov(rectangle, 100);

            rectangle.Width = 20;

            ValidateLiskov(rectangle, 200);
            Console.ReadLine();
        }

        private static void ValidateLiskov(Figure figure, int expectedArea)
        {
            var area = figure.CalculateArea();
            Console.WriteLine($"Area is {area} - expected {expectedArea}");
            var foregroundColor = Console.ForegroundColor;
            try
            {
                if (area != expectedArea)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Liskov violated because Height should not have been modified.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Liskov principal handled correctly.");
                }
            }
            finally
            {
                Console.ForegroundColor = foregroundColor;
            }
        }
    }
}