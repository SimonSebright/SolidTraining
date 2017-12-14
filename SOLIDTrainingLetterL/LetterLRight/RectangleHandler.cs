using System;

namespace LetterLRight
{
    public class RectangleHandler
    {
        public static int CalculateArea(int width, int height)
        {
            Console.WriteLine($"Area of rectangle with width {width} and height {height}");
            return width * height;
        }
        public static void Draw(int width, int height)
        {
            Console.WriteLine($"Drawing rectangle with width {width} and height {height}");
        }
    }
}