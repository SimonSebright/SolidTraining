using System;
using System.Collections.Generic;
using System.Text;

namespace LetterLRight
{
    public class Circle : Figure
    {
        private int _radius;

        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        public Circle(int radius)
        {
            Console.WriteLine($"Creating {typeof(Circle).FullName} with radius of {radius}");
            _radius = radius;
        }

        public int Radius
        {
            get => _radius;
            set
            {
                Console.WriteLine($"Updating {nameof(Radius)} to {value}.");
                _radius = value;
            }
        }


        public override int CalculateArea()
        {
            return (int) Math.Floor(3.142 * _radius * _radius);
        }

        public override void Draw()
        {
            Console.WriteLine($"Circle draw with radius  {_radius}");
        }
    }
}