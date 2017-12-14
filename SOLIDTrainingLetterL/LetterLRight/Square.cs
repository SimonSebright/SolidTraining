using System;
using System.Collections.Generic;
using System.Text;

namespace LetterLRight
{
    public class Square : Figure
    {
        private int _sideLength;

        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        public Square(int sideLength)
        {
            Console.WriteLine($"Creating {typeof(Square).FullName} with sideLength of {sideLength}");
            _sideLength = sideLength;
        }

        public int SideLength
        {
            get => _sideLength;
            set
            {
                Console.WriteLine($"Updating {nameof(SideLength)} to {value}.");
                _sideLength = value;
            }
        }
        public int Width
        {
            get => _sideLength;
        }

        public int Height
        {
            get => _sideLength;
        }

        public override int CalculateArea()
        {
            return RectangleHandler.CalculateArea(_sideLength, _sideLength);
        }

        public override void Draw()
        {
            RectangleHandler.Draw(_sideLength, _sideLength);
        }
    }
}