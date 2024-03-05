using System.ComponentModel.Design;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] arrayOfNames = { };
            while (true)
            {
                Console.WriteLine("Enter a name:");
                string name = Console.ReadLine();

                // Check if the first name is empty or consists only of whitespace
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Wrong input, please enter a name.");
                    continue;
                }
                else
                {
                    Array.Resize(ref arrayOfNames, arrayOfNames.Length + 1);
                    arrayOfNames[arrayOfNames.Length - 1] = name;

                    while (true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Do you wish to enter another name? Type y or n");
                        string yOrN = Console.ReadLine().ToLower();

                        if (string.IsNullOrWhiteSpace(yOrN))
                        {
                            Console.WriteLine("Please enter y or n");
                            continue;
                        }
                        else if (yOrN != "y" && yOrN != "n")
                        {
                            Console.WriteLine("Please enter y or n");
                            continue;
                        }

                        if (yOrN == "y")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Enter a name:");
                            string name2 = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(name2))
                            {
                                Console.WriteLine("Wrong input, please enter a name!");
                                Console.WriteLine("");
                                continue;
                            }

                            Array.Resize(ref arrayOfNames, arrayOfNames.Length + 1);
                            arrayOfNames[arrayOfNames.Length - 1] = name2;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Here are all the names you entered:");
                            for (int i = 0; i < arrayOfNames.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}.{arrayOfNames[i]}");
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }
    }
}
