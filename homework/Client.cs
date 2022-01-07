using System;

namespace homework
{
    class Client
    {
        public Client(string name, string surname, byte age, ushort salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
        }

        private static int ClassID { get; set; } = default;
        public int ID { get; } = ClassID++;

        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public ushort Salary { get; set; }
        public BankCard BankAccount { get; set; }

        public void Show()
        {
            Console.WriteLine(string.Format("Name: {0, -15} Surname: {1, -15} Age: {2, -10} Salary {3, -10}"));
        }
    }
}
