using System;

namespace LetterIRight
{
    public class RunnerDuck : IRunner, ISwimmer
    {
        public void Run()
        {
            Console.WriteLine("running");
        }


        public void Swim()
        {
            Console.WriteLine("swimming");
        }

    }
}