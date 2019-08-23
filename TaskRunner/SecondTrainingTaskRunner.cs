namespace Epam.HomeWork
{
    using System; 

    public class SecondTrainingTaskRunner : TaskRunner
    {
        public override void Run()
        {
            WriteHeaderMessage("Training 2");
            ConsolePause();

            RunTask1();
            ConsolePause();

            RunTask3();
            ConsolePause();

            RunTask4();
            ConsolePause();
            Console.Clear();
        }

        #region RunTask methods

        public void RunTask1()
        {
            const int FiguresArraySize = 4;
            WriteHeaderMessage(">> Task 1 and 2: abstract Figure class and Rectangle, Square child classes\n");

            var figures = new Training_2.Task_1_2.Figure[FiguresArraySize]
            {
                new Training_2.Task_1_2.Rectangle(8, 8),
                new Training_2.Task_1_2.Rectangle(9, 6),
                new Training_2.Task_1_2.Square(10, 0),
                new Training_2.Task_1_2.Square(9, 5)
            };

            foreach(var figure in figures)
            {
                Console.WriteLine(figure.Draw());
            }

        }

        public void RunTask3()
        {
            const int FiguresArraySize = 5;
            WriteHeaderMessage(">> Task 3: Figure class ( w/ virtual method Draw() ) " +
                "and Rectangle, Square child classes\n");

            var figures = new Training_2.Task_3.Figure[FiguresArraySize]
            {
                new Training_2.Task_3.Rectangle(8, 8),
                new Training_2.Task_3.Figure(9, 2),
                new Training_2.Task_3.Rectangle(9, 6),
                new Training_2.Task_3.Figure(10, 0),
                new Training_2.Task_3.Square(9, 5)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.Draw());
            }
        }

        public void RunTask4()
        {
            const int FiguresArraySize = 6;
            WriteHeaderMessage(">> Task 4: Figure class ( w/ virtual method Draw() " +
                "implementing IDrawable ) and Rectangle, Square child classes\n");

            var drawableFigures = new Training_2.IDrawable[FiguresArraySize]
            {
                new Training_2.Task_4.Rectangle(8, 8),
                new Training_2.Task_4.Figure(9, 2),
                new Training_2.Task_4.Rectangle(9, 6),
                new Training_2.Task_4.Figure(10, 0),
                new Training_2.Task_4.Square(9, 5),
                new Training_2.Task_4.Square(9, 5)
            };
            PrintDrawables(drawableFigures);
        }

        private static void PrintDrawables(params Training_2.IDrawable[] drawableFigures)
        {
            foreach (var figure in drawableFigures)
            {
                Console.WriteLine(figure.Draw());
            }
        }

        #endregion
    }
}
