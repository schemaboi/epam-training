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
            Console.Write("\nPress any key to continue...\n");
            Console.ReadLine();
        }

        public static void WriteHeaderMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
