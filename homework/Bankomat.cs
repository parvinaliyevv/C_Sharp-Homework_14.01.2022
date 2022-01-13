using System;

namespace homework
{
    internal static class Bankomat
    {
        public static void Menu(ref sbyte choice)
        {
            Console.WriteLine("[1] - Balance");
            Console.WriteLine("[2] - Cash");
            Console.WriteLine("[3] - Transfer");
            Console.WriteLine("[4] - Eject Card");
            Console.WriteLine("[5] - Eject and Exit\n");

            Console.Write("Enter your choice: ");
            choice = sbyte.Parse(Console.ReadLine());
        }

        public static void ShowBalance(Client user) => Console.WriteLine("Card balance: {0}", user.BankAccount.Balance);

        public static void ExtractMoney(Client user)
        {
            Console.WriteLine("[1] - 10 USD");
            Console.WriteLine("[2] - 20 USD");
            Console.WriteLine("[3] - 50 USD");
            Console.WriteLine("[4] - 100 USD");
            Console.WriteLine("[5] - other...\n");

            Console.Write("Choose one of the paragraphs: ");
            sbyte choice = sbyte.Parse(Console.ReadLine());

            if (choice == 5)
            {
                Console.Write("Include the amount of money: ");
                decimal money = decimal.Parse(Console.ReadLine());

                if (money < 0)
                {
                    throw new IndexOutOfRangeException("Money cannot be lower zero!");
                }
                else if (money > user.BankAccount.Balance)
                {
                    throw new IndexOutOfRangeException("Not much money on the card!");
                }
                else
                {
                    user.BankAccount.Balance -= money;
                }
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        if (user.BankAccount.Balance >= 10) user.BankAccount.Balance -= 10;
                        else throw new IndexOutOfRangeException("Not much money on the card!");
                        break;
                    case 2:
                        if (user.BankAccount.Balance >= 20) user.BankAccount.Balance -= 20;
                        else throw new IndexOutOfRangeException("Not much money on the card!");
                        break;
                    case 3:
                        if (user.BankAccount.Balance >= 50) user.BankAccount.Balance -= 50;
                        else throw new IndexOutOfRangeException("Not much money on the card!");
                        break;
                    case 4:
                        if (user.BankAccount.Balance >= 100) user.BankAccount.Balance -= 100;
                        else throw new IndexOutOfRangeException("Not much money on the card!");
                        break;
                    default:
                        Console.WriteLine("Wrong Include!");
                        break;
                }
            }

            Console.WriteLine("Money has been successfully withdrawn from the card!");
        }

        public static void TransferMoney(Bank bank, Client user)
        {
            Console.Write("Include PAN code card: ");
            string cardPAN = Console.ReadLine();

            Console.Write("Include the amount of money: ");
            decimal money = decimal.Parse(Console.ReadLine());

            if (money > user.BankAccount.Balance)
            {
                throw new IndexOutOfRangeException("Not much money on the card!");
            }

            bank.TransferMoney(user, cardPAN, money);
        }

    }

}
