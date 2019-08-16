namespace Epam.HomeWork
{
    using System;
    using System.Collections.Generic;

    public static class Program
    {
        static void Main(string[] args) 
        {
            var tasks = new List<IRunable>
            {
                new FirstTrainingTaskRunner(),
                new SecondTrainingTaskRunner()
            };

            foreach(var task in tasks)
            {
                task.Run();
            }

            TaskRunner.ConsolePause();
        }
    }
}
