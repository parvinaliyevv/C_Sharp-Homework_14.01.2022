using System;

namespace homework
{
    class Client
    {
        public Client(string name, string surname, byte age, ushort salary, BankCard bankAccount)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            BankAccount = bankAccount;

            Event = new System.Timers.Timer(30000);
            Event.Elapsed += SalaryTransfer;
            Event.Start();
        }

        private static uint ClassID { get; set; } = default;
        public uint ID { get; } = ClassID++;

        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public ushort Salary { get; set; }
        public BankCard BankAccount { get; set; }
        
        public System.Timers.Timer Event { get; set; }

        public void SalaryTransfer(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Salary transferred to the card (Balansa pul gelende hardan geldiyi bilinsin)");
            BankAccount.Balance += Salary;
        }

        public override string ToString()
        {
            return string.Format("Name: {0, -15} Surname: {1, -15} Age: {2, -10} Salary {3, -10}", Name, Surname, Age, Salary);
        }
    }
}
