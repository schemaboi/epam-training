namespace Epam.HomeWork
{
    using System;

    public abstract class TaskRunner
    {

        protected TaskRunner()
        {
        }

        public abstract void Run();

        public static void ConsolePause()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void WriteHeaderMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
