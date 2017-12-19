using System;

namespace LetterIWrong
{
    public class Duck : IDuck
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