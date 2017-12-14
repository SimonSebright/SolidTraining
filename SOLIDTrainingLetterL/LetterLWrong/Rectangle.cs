using System;

namespace LetterLWrong
{
    public class Rectangle : Figure
    {
        private int _height;
        private int _width;

        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        public Rectangle(int width, int height)
        {
            Console.WriteLine($"Creating {typeof(Rectangle).FullName} with width of {width} and height of {height}");

            Width = width;
            Height = height;
        }

        public virtual int Width
        {
            get => _width;
            set
            {
                Console.WriteLine($"Updating {nameof(Width)} to {value}.");
                _width = value;
            }
        }

        public virtual int Height
        {
            get => _height;
            set
            {
                Console.WriteLine($"Updating {nameof(Height)} to {value}.");
                _height = value;
            }
        }

        public override int CalculateArea()
        {
            return _height * _width;
        }
    }
}