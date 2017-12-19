using System;

namespace LetterIRight
{
    public class Program
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
            //DoFly(runnerDuck);

            Console.ReadLine();
        }
        private static void DoSwim(ISwimmer swimmer)
        {
            swimmer.Swim();
        }

        private static void DoFly(IFlyer flyer)
        {
            flyer.Fly();
        }

        private static void DoRun(IRunner runner)
        {
            runner.Run();
        }
    }
}