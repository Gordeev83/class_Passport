namespace class_Passport
{
    public class Passport
    {
        private string passportNumber;
        private string fullName;
        private DateTime issueDate;

        public Passport(string passportNumber, string fullName, DateTime issueDate)
        {
            if (string.IsNullOrEmpty(passportNumber))
            {
                throw new ArgumentException("неверное значение номера паспорта");
            }

            if (string.IsNullOrEmpty(fullName))
            {
                throw new ArgumentException("неверное значение фио владельца");
            }

            if (issueDate == DateTime.MinValue)
            {
                throw new ArgumentException("неверное значение даты выдачи");
            }

            this.passportNumber = passportNumber;
            this.fullName = fullName;
            this.issueDate = issueDate;
        }

        public string PassportNumber
        {
            get { return passportNumber; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("неверное значение номера паспорта");
                }
                passportNumber = value;
            }
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("неверное значение фио владельца");
                }
                fullName = value;
            }
        }

        public DateTime IssueDate
        {
            get { return issueDate; }
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new ArgumentException("неверное значение даты выдачи");
                }
                issueDate = value;
            }
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                // инициализация полей класса
                var passport = new Passport("123456789", "иванов иван иванович", new DateTime(2020, 1, 1));

                // изменение полей класса
                passport.PassportNumber = "987654321";
                passport.FullName = "петров петр петрович";
                passport.IssueDate = new DateTime(2021, 1, 1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
