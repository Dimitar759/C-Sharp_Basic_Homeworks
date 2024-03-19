using System;
using System.Collections.Generic;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            while (true)
            {
                Console.WriteLine("Please input a number:");
                string num = Console.ReadLine();

                if (!string.IsNullOrEmpty(num) && int.TryParse(num, out int number))
                {
                    queue.Enqueue(number);

                    Console.WriteLine("Do you wish to enter another number? Enter y or n:");
                    string yOrN = Console.ReadLine().ToLower();

                    if (yOrN != "y" && yOrN != "n")
                    {
                        Console.WriteLine("Wrong input!");
                        return;
                    }
                    else if (yOrN == "n")
                    {
                        break;
                    }
                    else if(yOrN == "y")
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                    return;
                }
            }

            Console.WriteLine("\nThe numbers you inputted are:");

            foreach (int n in queue)
            {
                Console.WriteLine(n);
            }
        }
    }
}