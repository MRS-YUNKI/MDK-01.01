using System.Globalization;

class Bank
{
    static void Main(string[] args)
    {
        BankAccount Account = new BankAccount("1234-5678-9000", "Givarov Ivan Ivanovich", 1353.0m);

        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Узнать баланс");
            Console.WriteLine("2. Пополнить баланс");
            Console.WriteLine("3. Снять со счета");
            Console.WriteLine("4. Перевести средства");
            Console.WriteLine("5. Посмотреть информацию о счете");
            Console.WriteLine("6. Выход");

            Console.Write("Выберите опцию (1-6): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Текущий баланс: {Account.GetBalance()}");
                    break;
                case "2":
                    Console.WriteLine("Введите сумму пополнения:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal r_amount))
                    {
                        Account.Replenishment(r_amount);
                    } else
                    {
                        Console.WriteLine("Некорректная сумма пополнения.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Введите сумму снятия:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal w_amount))
                    {
                        Account.Withdraw(w_amount);
                    } else
                    {
                        Console.WriteLine("Некорректная сумма снятия.");
                    }
                    break;
                case "4":
                    BankAccount AnotherAccount = new BankAccount("0009-8765-4321", "Philatov Andrey Pavlowich", 3276.0m);

                    Console.WriteLine("Введите сумму перевода:");
                    if (decimal.TryParse(Console.ReadLine(), out decimal t_amount))
                    {
                        Account.Transfer(AnotherAccount, t_amount);
                    } else
                    {
                        Console.WriteLine("Некорректная сумма перевода.");
                    }
                    break;
                case "5":
                    Account.GetAccountInfo();
                    break;
                case "6":
                    break;
            }
        }
    }

    class BankAccount
    {
        private string account_number;
        private string owner_fullname;
        private decimal balance;

        public BankAccount()
        {
            account_number = "0000-000-00";
            owner_fullname = "Unknown";
            balance = 0.0m;
        }

        public BankAccount(string account_number, string owner_fullname, decimal b_balance)
        {
            this.account_number = account_number;
            this.owner_fullname = owner_fullname;
            this.balance = b_balance;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Replenishment(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"На счет {account_number} положено {amount}. Теперь доступно: {balance}.");
            } else
            {
                Console.WriteLine("Сумма пополнения должна быть больше нуля (0).");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance && amount > 0)
            {
                balance -= amount;
                Console.WriteLine($"Со счета {account_number} снято {amount}. Доступно на счете: {balance}.");
            } else if (balance < amount)
            {
                Console.WriteLine("Недостаточно средств для снятия такой суммы средств.");
            } else
            {
                Console.WriteLine("Сумма снятия должна быть больше нуля (0).");
            }
        }

        public void Transfer(BankAccount ThisAccount, decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                if (amount <= balance && amount > 0)
                {
                    balance -= amount;
                    ThisAccount.balance += amount;
                    Console.WriteLine($"Переведено {amount} на счет {ThisAccount.account_number}.");
                }
                else if (balance < amount)
                {
                    Console.WriteLine("Недостаточно средств для перевода.");
                }
                else
                {
                    Console.WriteLine("Сумма перевода должна быть больше нуля (0).");
                }
            }
        }

        public void GetAccountInfo()
        {
            Console.WriteLine($"Номер счета: {account_number}.\nВладелец: {owner_fullname}.\nБаланс счета: {balance}.");
        }
    }
}