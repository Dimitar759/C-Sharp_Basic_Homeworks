namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your card number:");
            string cardNumber = Console.ReadLine();

            Customers customer = Customers.Authenticate(cardNumber);

            if (customer != null)
            {
                Console.WriteLine($"Welcome, {customer.FullName}!");

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Cash Withdrawal");
                Console.WriteLine("3. Cash Deposition");

                string choiceInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(choiceInput) && int.TryParse(choiceInput, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine($"Your current balance is: {customer.GetBalance()}");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Enter the amount to withdraw:");
                            string withdrawInput = Console.ReadLine();
                            if (!string.IsNullOrEmpty(withdrawInput) && int.TryParse(withdrawInput, out int withdrawAmount))
                            {
                                if (withdrawAmount > 0)
                                {
                                    Console.WriteLine("");
                                    string withdrawalResult = customer.Withdraw(withdrawAmount);
                                    Console.WriteLine(withdrawalResult);
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter an amount greater than 0.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Invalid input. Please enter a valid amount.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("");
                            Console.WriteLine("Enter the amount to deposit:");
                            string depositInput = Console.ReadLine();
                            if (!string.IsNullOrEmpty(depositInput) && int.TryParse(depositInput, out int depositAmount))
                            {
                                if (depositAmount > 0)
                                {
                                    Console.WriteLine("");
                                    string depositResult = customer.Deposit(depositAmount);
                                    Console.WriteLine(depositResult);
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("Enter an amount greater than 0.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Invalid input. Please enter a valid amount.");
                            }
                            break;
                        default:

                            break;
                    }

                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid choice. Enter a number between 1 and 3!");
                }


            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }

        }
    }
}

