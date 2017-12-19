using System;

namespace LetterIWrong
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var duck = new Duck();
            DoRun(duck);
            DoSwim(duck);
            DoFly(duck);

            var runnerDuck = new RunnerDuck();
            DoRun(runnerDuck);
            DoSwim(runnerDuck);
            DoFly(runnerDuck);

            Console.ReadLine();
        }

        private static void DoSwim(IDuck duck)
        {
            duck.Swim();
        }

        private static void DoFly(IDuck duck)
        {
            duck.Fly();
        }

        private static void DoRun(IDuck duck)
        {
            duck.Run();
        }
    }
}