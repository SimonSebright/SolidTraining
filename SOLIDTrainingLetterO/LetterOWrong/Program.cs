using System;

namespace LetterOWrong
{
    internal static class Program
    {
        internal static void Main(string[] args)
        {
            try
            {
                var logic = new MailingLogic();
                logic.ProcessMailing("MailListFile.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}