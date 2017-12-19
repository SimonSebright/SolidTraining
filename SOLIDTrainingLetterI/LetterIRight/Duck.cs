using System;

namespace LetterIRight
{
    public class Duck : IRunner, ISwimmer, IFlyer
    {
        public void Run()
        {
            Console.WriteLine("running");
        }

        public void Fly()
        {
            Console.WriteLine("flying");
        }

        public void Swim()
        {
            Console.WriteLine("swimming");
        }
    }
}