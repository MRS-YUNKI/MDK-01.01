using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        

        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1.Создать аккаунт");
            Console.WriteLine("2. Пополнить баланс");
            Console.WriteLine("3. Снять со счета");
            Console.WriteLine("4. Перевести средства");
            Console.WriteLine("5. Посмотреть информацию о счете");
            Console.WriteLine("6. Выход");

            Console.WriteLine("Выберите опцию (1-6):");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Введите номер счета:");
                    string account_number = Console.ReadLine();
                    Console.WriteLine("Введите полное ФИО владельца:");
                    string owner_fullname = Console.ReadLine();
                    Console.WriteLine("Введите начальный баланс:");
                    decimal b_balance;

                    while 
                case "2":
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

        public void Replenishment(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"На счет {account_number} положено {amount}. Теперь доступно: {balance}.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance && amount > 0)
            {
                balance -= amount;
                Console.WriteLine($"Со счета {account_number} снято {amount}. Доступно на счете: {balance}");
            } else
            {
                Console.WriteLine("Недостаточно средств для снятия такой суммы средств.");
            }
        }


        public void Transfer()
        {

        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void GetAccountInfo()
        {
            Console.WriteLine($"Номер счета: {account_number}.\nВладелец: {owner_fullname}.\nБаланс счета: {balance}.");
        }
    }
}