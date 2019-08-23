namespace Epam.HomeWork
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using Training_3;

    public class ThirdTrainingTaskRunner : TaskRunner
    {
        private const int PageSize = 5;
        private PeopleList peopleList;

        public override void Run()
        {
            InitList();

            WriteHeaderMessage("Training 3");
            ConsolePause();

            RunTask1();
            ConsolePause();

            RunTask2();
            ConsolePause();

            RunTask3();
            ConsolePause();

            RunTask3Linq();
            ConsolePause();
            Console.Clear();
        }

        #region RunTask methods

        public void RunTask1()
        {
            WriteHeaderMessage(">> Task 1:\n");

            peopleList.PrintAll();
        }

        public void RunTask2()
        {
            WriteHeaderMessage(">> Task 2:\n");

            peopleList.AddPeopleRange(new List<Person>
            {
                new Person("Svyatik", 19,
                    new List<ContactNumber>
                        {
                            new ContactNumber("Pavlo", "+380974598784"),
                            new ContactNumber("Sergii", "+380937896457"),
                            new ContactNumber("Nastya", "+380954884137"),
                            new ContactNumber("Mike", "+380974548846")
                        }),

                new Person("Andrew", 20,
                    new List<ContactNumber>
                        {
                            new ContactNumber("Pavlo", "+380974598784"),
                            new ContactNumber("Sergii", "+380937896457"),
                            new ContactNumber("Nastya", "+380954884137"),
                            new ContactNumber("Mike", "+380974548846")
                        })
            });

            peopleList.PrintAllWithPhoneNumbers();
        }

        public void RunTask3()
        {
            const int RandomStringsCount = 100;
            const int RandomStringLength = 4;

            WriteHeaderMessage(">> Task 3:\n");

            List<string> strings = GetRandomStringsWithCapitalLetters(RandomStringsCount, RandomStringLength);

            strings.RemoveAll(s => s.StartsWith('Z'));

            var set = new HashSet<string>();
            set.UnionWith(strings);

            strings = new List<string>(set); 

            Console.WriteLine($"{RandomStringsCount - strings.Count} strings were removed from the list!\n" +
                $"There are {strings.Count} strings in the list now.\n");

            strings.Sort((a, b) => -1 * a.CompareTo(b));

            Console.Write("Enter page number to be displayed: ");
            if(!int.TryParse(Console.ReadLine(), out int pageNumber))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            DisplayPage(pageNumber, strings);
        }
                     
        #endregion

        void RunTask3Linq()
        {
            const int RandomStringsCount = 100;
            const int RandomStringLength = 4;

            WriteHeaderMessage(">> Task 3 with LINQ:\n");

            List<string> strings = GetRandomStringsWithCapitalLetters(RandomStringsCount, RandomStringLength);
             
            var newStrings = strings.Where(s => !s.StartsWith('Z')).Distinct().ToList();

            Console.WriteLine($"{newStrings.Count} strings were removed from the list!\n" +
                $"There are {strings.Count} strings in the list now.\n");

            newStrings = (from str in newStrings
                          orderby str descending
                          select str).ToList();

            Console.Write("Enter page number to be displayed: ");
            if (!int.TryParse(Console.ReadLine(), out int pageNumber))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            DisplayPage(pageNumber, newStrings);
        }

        #region Helper methods

        private void InitList()
        {
            var people = new List<Person>
            {
                new Person("Roman Moravskyi", 19,
                    new List<ContactNumber>
                    {
                        new ContactNumber("Pavlo", "+380974598784"),
                        new ContactNumber("Sergii", "+380937896457"),
                        new ContactNumber("Nastya", "+380954884137"),
                        new ContactNumber("Mike", "+380974548846")
                    }),

                new Person("Anastasia Vasileva", 18,
                    new List<ContactNumber>
                    {
                        new ContactNumber("Roman", "+380962522749"),
                        new ContactNumber("Sergii", "+380937896457")
                    }),

                new Person("Sergii Ivanenko", 19,
                    new List<ContactNumber>
                    {
                        new ContactNumber("Pavlo", "+380974598784"),
                        new ContactNumber("Roman", "+380962522749")
                    }),

                new Person("Pavlo Pustelnyk", 19,
                    new List<ContactNumber>
                    {
                        new ContactNumber("Roman", "+380962522749"),
                        new ContactNumber("Sergii", "+380937896457")
                    }),

                new Person("Mykola Morozov", 18,
                    new List<ContactNumber>
                    {
                        new ContactNumber("Roman", "+380962522749"),
                        new ContactNumber("Nastya", "+380954884137")
                    }),
            };

            peopleList = new PeopleList(people);
        }

        private List<string> GetRandomStringsWithCapitalLetters(int size, int length)
        {
            var strings = new List<string>();

            for (int i = 0; i < size; ++i)
            {
                strings.Add(GetRandomString(length).ToUpper());
            }

            return strings;
        }

        private static string GetRandomString(int length)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < length; ++i)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            return builder.ToString();
        }

        private void DisplayPage(int pageNumber, List<string> strings)
        {
            if (pageNumber < 1)
                return;

            int startingIndex = PageSize * (pageNumber - 1);
            int endingIndex = PageSize * pageNumber - 1;

            if (startingIndex > strings.Count)
            {
                Console.WriteLine($"Page number {pageNumber} does not exist!");
            }

            for(int i = startingIndex; i < strings.Count && i <= endingIndex; ++i)
            {
                Console.WriteLine(strings[i]);
            }
        }

        #endregion
    }
}
