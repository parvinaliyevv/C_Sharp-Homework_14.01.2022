using System;

namespace homework
{
    class BankCard
    {
        public string BankName { get; set; }
        public string FullName { get; set; }

        public string PAN { get; init; }
        public string PIN { get; init; }
        public string CVC { get; init; }

        public string ExpireData { get; set; }

        public decimal Balance { get; set; }

        public BankCard(string bankName, string fullName, decimal balance)
        {
            BankName = bankName;
            FullName = fullName;
            Balance = balance;

            PAN = MyRandom.RandomString(16);
            PIN = MyRandom.RandomString(4);
            CVC = Convert.ToString(MyRandom.RandomInteger(100, 1000));

            ExpireData = string.Format("{0:00}/{1}", MyRandom.RandomInteger(1, 13), MyRandom.RandomInteger(2025, 2035));
        }

        public override string ToString()
        {
            return string.Format("Bank Name: {0}\nFull Name: {1}\nPAN: {2}\nCVC: {3}\nExpire Data: {4}\nBalance: {5}"
                , BankName, FullName, PAN, CVC, ExpireData, Balance);
        }
    }
}
