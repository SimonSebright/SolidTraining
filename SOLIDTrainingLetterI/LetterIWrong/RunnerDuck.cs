using System;

namespace LetterIWrong
{
    public class RunnerDuck : IDuck
    {
        public void Run()
        {
            Console.WriteLine("running");
        }

        public void Fly()
        {
            throw new NotSupportedException();
        }

        public void Swim()
        {
            Console.WriteLine("swimming");
        }

    }
}