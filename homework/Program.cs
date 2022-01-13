using System;
using homework;

sbyte choice;
var bank = new Bank("Yellow Bank");
Client user = null;

bank.AppendClient(new Client("Parvin", "Aliyev", 17, 50, new BankCard(bank.BankName, "Parvin Aliyev", 100)));
bank.AppendClient(new Client("Farman", "Asadov", 16, 60, new BankCard(bank.BankName, "Farman Asadov", 100)));
bank.AppendClient(new Client("Ramazan", "Mustafazade", 8, 70, new BankCard(bank.BankName, "Senior Developer", 9999999)));
bank.AppendClient(new Client("Elgun", "Salmanof", 17, 80, new BankCard(bank.BankName, "Elgun Salmanof", 100)));
bank.AppendClient(new Client("Murad", "Musali", 15, 90, new BankCard(bank.BankName, "Murad Musali", 100)));
Console.ReadKey();

respawn:
Console.Clear();
user = null;

Console.Write("Enter your card PIN: ");
user = bank.GetClient(Console.ReadLine());

if (user is null)
{
    Console.WriteLine("Wrong PIN code!");
    Console.ReadKey();
    goto respawn;
}

Console.Clear();
while (true)
{
    choice = default;

    Bankomat.Menu(ref choice);
    Console.Clear();

    try
    {
        if (choice == 1)
        {
            Bankomat.ShowBalance(user);
        }
        else if (choice == 2)
        {
            Bankomat.ExtractMoney(user);
        }
        else if (choice == 3)
        {
            Bankomat.TransferMoney(bank, user);
        }
        else if (choice == 4)
        {
            goto respawn;
        }
        else if (choice == 5)
        {
            break;
        }
        else
        {
            Console.WriteLine("Wrong Include!");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.ReadKey();
    Console.Clear();
}
