using System;

namespace LetterLRight
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("1 = Rectangle, 2 = Square");

            var userDecision = Console.ReadLine();

            // Write your code here!

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