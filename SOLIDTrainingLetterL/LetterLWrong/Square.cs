using System;

namespace LetterLWrong
{
    public class Square : Rectangle
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Object"></see> class.</summary>
        public Square(int sideLength) : base(sideLength, sideLength)
        {
            Console.WriteLine($"Creating {typeof(Square).FullName} with sideLength of {sideLength}");
        }

        public override int Width
        {
            get => base.Width;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            get => base.Height;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
    }
}