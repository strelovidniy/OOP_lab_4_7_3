using System;
using System.IO;

namespace OOP_lab_4_7_3
{
    class Work
    {
        public static void Add()
        {
            Console.WriteLine("Введiть данi");

            string str = Console.ReadLine();

            string[] elements = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Parse(elements, true);

            Input.Key();
        }

        public static void Remove()
        {
            Console.Write("Прiзвище викладача: ");

            string surename = Console.ReadLine();

            bool[] write = new bool[Program.schedule.Length];

            for (int i = 0; i < Program.schedule.Length; ++i)
            {
                if (Program.schedule[i] != null)
                {
                    if (Program.schedule[i].Surename == surename)
                    {
                        Console.WriteLine("{0,-15} {1, -15} {2, -30} {3, -30} {4, -15}", Program.schedule[i].Number, Program.schedule[i].Day, Program.schedule[i].Subject, Program.schedule[i].Surename, Program.schedule[i].Form);

                        Console.WriteLine("Видалити? (Y/N)");

                        var key = Console.ReadKey().Key;

                        if (key == ConsoleKey.Y)
                        {
                            Program.delete[i] = true;
                        }
                        else
                        {
                            Program.delete[i] = false;
                        }
                    }
                }
            }
        }

        public static void Edit()
        {
            Console.Write("Прiзвище викладача: ");

            string surename = Console.ReadLine();

            bool[] write = new bool[Program.schedule.Length];

            for (int i = 0; i < Program.schedule.Length; ++i)
            {
                if (Program.schedule[i] != null)
                {
                    if (Program.schedule[i].Surename == surename)
                    {
                        Console.WriteLine("{0,-15} {1, -15} {2, -30} {3, -30} {4, -15}", Program.schedule[i].Number, Program.schedule[i].Day, Program.schedule[i].Subject, Program.schedule[i].Surename, Program.schedule[i].Form);

                        Console.WriteLine("Введiть нову iнформацiю");

                        string str = Console.ReadLine();

                        string[] elements = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                        Program.schedule[i] = new Schedule(int.Parse(elements[0]), elements[1], elements[2], elements[3], elements[4]);
                    }
                }
            }
        }

        public static void Find()
        {
            Console.Write("Прiзвище викладача: ");

            string surename = Console.ReadLine();

            bool[] write = new bool[Program.schedule.Length];

            for (int i = 0; i < Program.schedule.Length; ++i)
            {
                if (Program.schedule[i] != null)
                {
                    if (Program.schedule[i].Surename == surename)
                    {
                        write[i] = true;
                    }
                    else
                    {
                        write[i] = false;
                    }
                }
                
            }

            Output.Write(Program.schedule, write);

            Input.Key();
        }

        public static void Sort()
        {
            int index = 0;

            while (Program.schedule[index + 1] != null)
            {
                for (int i = 0; i < Program.schedule.Length - 1; ++i)
                {
                    if (Program.schedule[i + 1] != null)
                    {
                        if (Program.schedule[i].DayNumber > Program.schedule[i + 1].DayNumber)
                        {
                            string tempStr;
                            int tempInt;

                            tempInt = Program.schedule[i].Number;
                            Program.schedule[i].Number = Program.schedule[i + 1].Number;
                            Program.schedule[i + 1].Number = tempInt;

                            tempInt = Program.schedule[i].DayNumber;
                            Program.schedule[i].DayNumber = Program.schedule[i + 1].DayNumber;
                            Program.schedule[i + 1].DayNumber = tempInt;

                            tempStr = Program.schedule[i].Day;
                            Program.schedule[i].Day = Program.schedule[i + 1].Day;
                            Program.schedule[i + 1].Day = tempStr;

                            tempStr = Program.schedule[i].Subject;
                            Program.schedule[i].Subject = Program.schedule[i + 1].Subject;
                            Program.schedule[i + 1].Subject = tempStr;

                            tempStr = Program.schedule[i].Surename;
                            Program.schedule[i].Surename = Program.schedule[i + 1].Surename;
                            Program.schedule[i + 1].Surename = tempStr;

                            tempStr = Program.schedule[i].Form;
                            Program.schedule[i].Form = Program.schedule[i + 1].Form;
                            Program.schedule[i + 1].Form = tempStr;
                        }
                    }
                }

                ++index;
            }

            Output.Write(Program.schedule);

            Input.Key();
        }

        private static void Save(Schedule s)
        {
            StreamWriter save = new StreamWriter("base.txt", true);

            save.WriteLine(s.Number);
            save.WriteLine(s.Day);
            save.WriteLine(s.Subject);
            save.WriteLine(s.Surename);
            save.WriteLine(s.Form);

            save.Close();
        }

        public static void Parse(string[] elements, bool save)
        {
            int counter = 0;

            while (Program.schedule[counter] != null)
            {
                ++counter;
            }

            for (int i = 0; i < elements.Length; i += 5)
            {
                Program.schedule[counter + i / 5] = new Schedule(int.Parse(elements[i]), elements[i + 1], elements[i + 2], elements[i + 3], elements[i + 4]);
                if (save)
                {
                    Save(Program.schedule[counter + i / 5]);
                }
            }
        }
    }
}
