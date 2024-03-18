using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Customers
    {
        public string CardNumber { get; set; }
        private int Pin { get; set; }
        public string FullName { get; set; }
        private int Balance { get; set; }

        public Customers(string cardNumber, int pin, string fullName, int balance)
        {
            CardNumber = cardNumber;
            Pin = pin;
            FullName = fullName;
            Balance = balance;
        }

        public Customers()
        {
        }

        public static Customers Authenticate(string cardNumber)
        {
            if (cardNumber == "1234-1234-1234-1234" || cardNumber == "8390-8390-8390-8390" ||
                cardNumber == "7379-7379-7379-7379" || cardNumber == "2865-2865-2865-2865")
            {
                if (cardNumber == "1234-1234-1234-1234")
                {
                    Console.WriteLine("Welcome Max Tennyson");
                }
                else if (cardNumber == "8390-8390-8390-8390")
                {
                    Console.WriteLine("Welcome Kevin Levin");
                }
                else if (cardNumber == "7379-7379-7379-7379")
                {
                    Console.WriteLine("Welcome Gwen Stacey");
                }
                else if (cardNumber == "2865-2865-2865-2865")
                {
                    Console.WriteLine("Welcome Becky Smith");
                }

                Console.WriteLine("");

                Console.WriteLine("Please input your pin:");
                string pinEntered = Console.ReadLine();
                if (!string.IsNullOrEmpty(pinEntered) && int.TryParse(pinEntered, out int pin))
                {
                    if ((cardNumber == "1234-1234-1234-1234" && pin == 4321) ||
                    (cardNumber == "8390-8390-8390-8390" && pin == 1835) ||
                    (cardNumber == "7379-7379-7379-7379" && pin == 8653) ||
                    (cardNumber == "2865-2865-2865-2865" && pin == 7294))
                    {

                        Console.WriteLine("");
                        switch (cardNumber)
                        {
                            case "1234-1234-1234-1234":
                                return new Customers("1234-1234-1234-1234", 4321, "Max Tennyson", 1000);
                            case "8390-8390-8390-8390":
                                return new Customers("8390-8390-8390-8390", 1835, "Kevin Levin", 2000);
                            case "7379-7379-7379-7379":
                                return new Customers("7379-7379-7379-7379", 8653, "Gwen Stacey", 3000);
                            case "2865-2865-2865-2865":
                                return new Customers("2865-2865-2865-2865", 7294, "Becky Smith", 4000);
                            default:
                                return null;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid pin");
                }
            }
            else
            {
                Console.WriteLine("Invalid card number");
            }
            return null;
        }

        public string GetBalance()
        {
            return $"{Balance}";
        }

        public string Withdraw(int amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return $"Withdrawal successful. Amount withdrawn: {amount}. New balance: {Balance}$";
            }
            else
            {
                return "You aint got that much money bro LOL, work more!";
            }
        }

        public string Deposit(int amount)
        {
            Balance += amount;
            return $"Deposit successful. New balance: {Balance}$";
        }
    }
}


