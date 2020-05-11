namespace OOP_lab_4_7_3
{
    class Schedule
    {
        private int _number;
        private int _dayNumber;
        private string _day;
        private string _subject;
        private string _surename;
        private string _form;

        public int Number
        {
            get => _number;
            set => _number = value;
        }
        public int DayNumber
        {
            get => _dayNumber;
            set => _dayNumber = value;
        }
        public string Day
        {
            get => _day;
            set => _day = value;
        }
        public string Subject
        {
            get => _subject;
            set => _subject = value;
        }
        public string Surename
        {
            get => _surename;
            set => _surename = value;
        }
        public string Form
        {
            get => _form;
            set => _form = value;
        }

        private int DayStrToInt(string str)
        {
            if (str == "Понеділок")
            {

                return 1;
            }

            if (str == "Вівторок")
            {
                return 2;
            }

            if (str == "Неділя")
            {
                return 7;
            }

            if (str == "Понедiлок")
            {
                return 1;
            }

            if (str == "Вiвторок")
            {
                return 2;
            }

            if (str == "Середа")
            {
                return 3;
            }

            if (str == "Четвер")
            {
                return 4;
            }

            if (str == "П'ятниця")
            {
                return 5;
            }

            if (str == "Субота")
            {
                return 6;
            }

            if (str == "Недiля")
            {
                return 7;
            }

            return 0;
        }

        public Schedule()
        {
            Number = 0;
            Day = "Не вказано";
            DayNumber = DayStrToInt(Day);
            Surename = "Не вказано";
            Form = "Не вказано";
        }

        public Schedule(int number)
        {
            Number = number;
            Day = "Не вказано";
            DayNumber = DayStrToInt(Day);
            Surename = "Не вказано";
            Form = "Не вказано";
        }

        public Schedule(int number, string day)
        {
            Number = number;
            Day = day;
            DayNumber = DayStrToInt(Day);
            Surename = "Не вказано";
            Form = "Не вказано";
        }

        public Schedule(int number, string day, string subject)
        {
            Number = number;
            Day = day;
            DayNumber = DayStrToInt(Day);
            Subject = subject;
            Surename = "Не вказано";
            Form = "Не вказано";
        }

        public Schedule(int number, string day, string subject, string surename)
        {
            Number = number;
            Day = day;
            DayNumber = DayStrToInt(Day);
            Subject = subject;
            Surename = surename;
            Form = "Не вказано";
        }

        public Schedule(int number, string day, string subject, string surename, string form)
        {
            Number = number;
            Day = day;
            DayNumber = DayStrToInt(Day);
            Subject = subject;
            Surename = surename;
            Form = form;
        }
    }
}
