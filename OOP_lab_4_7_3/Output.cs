using System;

namespace OOP_lab_4_7_3
{
    class Output
    {
        public static void Write(Schedule[] s)
        {
            Console.WriteLine("{0,-15} {1, -15} {2, -30} {3, -30} {4, -15}", "Номер пари", "День тижня", "Предмет", "Прiзвище викладача", "Форма заняття");

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] != null)
                {
                    Console.WriteLine("{0,-15} {1, -15} {2, -30} {3, -30} {4, -15}", Program.schedule[i].Number, Program.schedule[i].Day, Program.schedule[i].Subject, Program.schedule[i].Surename, Program.schedule[i].Form);
                }
            }
        }

        public static void Write(Schedule[] s, bool[] write)
        {
            Console.WriteLine("{0,-15} {1, -15} {2, -30} {3, -30} {4, -15}", "Номер пари", "День тижня", "Предмет", "Прiзвище викладача", "Форма заняття");

            for (int i = 0; i < s.Length; ++i)
            {
                if ((write[i]) &&(!Program.delete[i]))
                {
                    Console.WriteLine("{0,-15} {1, -15} {2, -30} {3, -30} {4, -15}", Program.schedule[i].Number, Program.schedule[i].Day, Program.schedule[i].Subject, Program.schedule[i].Surename, Program.schedule[i].Form);
                }
            }
        }
    }
}
