using System;

namespace homework
{
    class Bank
    {
        public string BankName { get; set; }
        private Client[] Clients { get; set; } = new Client[0];

        public Bank(string bankName) =>  BankName = bankName;

        public void AppendClient(Client client)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));

            var newClients = new Client[Clients.Length + 1];

            for (int i = 0; i < Clients.Length; i++)
            {
                newClients[i] = Clients[i];
            }

            newClients[Clients.Length] = client;
            Clients = newClients;

            Console.WriteLine("Do not show your PIN to anyone: {0}", client.BankAccount.PIN);
            Console.WriteLine("PAN code(test ucun): {0}\n", client.BankAccount.PAN);
        }

        public void NewClient()
        {
            string name, surname;
            ushort salary;
            byte age;

            Console.Write("Include your name: ");
            name = Console.ReadLine();

            Console.Write("Include your surname: ");
            surname = Console.ReadLine();

            Console.Write("Include your age: ");
            age = byte.Parse(Console.ReadLine());

            Console.Write("Include your salary: ");
            salary = ushort.Parse(Console.ReadLine());

            var bankCard = new BankCard(BankName, name + ' ' + surname, 100);
            var client = new Client(name ,surname, age, salary, bankCard);

            AppendClient(client);
        }

        public Client GetClient(string PIN)
        {
            foreach (var client in Clients)
            {
                if (Object.Equals(client.BankAccount.PIN, PIN)) return client;
            }

            return null;
        }

        public void TransferMoney(Client user, string cardPAN, decimal money) 
        {
            foreach (var client in Clients)
            {
                if (client.BankAccount.PAN.Equals(cardPAN))
                {
                    client.BankAccount.Balance += money;
                    user.BankAccount.Balance -= money;
                    Console.WriteLine("Money success transfered!");
                    return;
                }
            }
        }
    }
}
