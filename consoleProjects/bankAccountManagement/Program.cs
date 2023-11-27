namespace bankAccountManagement
{
    internal class Program
    {
        class BankAccount
        {
            private string accountNumber;
            private string accountHolder;
            private decimal balance;


            public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
            {
                this.accountNumber = accountNumber;
                this.accountHolder = accountHolder;
                this.balance = initialBalance;
            }
            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    balance += amount; //adds amount to balance
                    Console.WriteLine($"Deposited ${amount}. New balance: ${balance}");
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount. Please enter a positive number.");
                }
            }
            public void Withdraw(decimal amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount; // subtracts amount from balance.
                    Console.WriteLine($"Withdrawn ${amount}. New balance: ${balance}");
                }
                else if (amount > balance)
                {
                    Console.WriteLine("Insufficient funds.");
                }
                else
                {
                    Console.WriteLine("Invalid withdrawal amount. Please enter a positive number.");
                }
            }
            public void DisplayAccountInfo()
            {
                Console.WriteLine($"Account Number: {accountNumber} ");
                Console.WriteLine($"Account Holder: {accountHolder}");
                Console.WriteLine($"Balance : ${balance}");
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Bank Account Management");

                // Creating a new bank account example
                BankAccount myAccount = new BankAccount("123456", "John Doe", 1000);

                while (true)
                {
                    Console.WriteLine($"Menu:");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Display Account Information");
                    Console.WriteLine("4. Exit");

                    Console.Write("Enter Your choice:");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter deposit amount:");
                            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                            {
                                myAccount.Deposit(depositAmount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                        break;

                        case "2":
                            Console.Write("Enter withdrawal amount:");
                            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount))
                            {
                              myAccount.Withdraw(withdrawalAmount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                        break;    

                        case "3":
                            myAccount.DisplayAccountInfo();
                        break;

                        case "4":
                            Environment.Exit(0);
                        break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                        break;

                    }
                }




            }



        }
    }
}