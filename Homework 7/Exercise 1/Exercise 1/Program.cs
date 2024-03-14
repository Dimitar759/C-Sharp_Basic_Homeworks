using Exercise_1;

namespace Exercise_1
{
    public class Program 
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter a number: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input) || !double.TryParse(input, out double number))
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    Console.WriteLine("");
                    continue;
                }

                NumberCheck checker = new NumberCheck();
                checker.NumberStats(number);

                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Do you want to enter another number? - Enter y/n");
                    string inputAgain = Console.ReadLine().ToLower();

                    if (string.IsNullOrEmpty(inputAgain))
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Enter a valid input please");
                    }
                    else if (inputAgain == "n")
                    {
                        return;
                    }
                    else if (inputAgain == "y")
                    {
                        Console.WriteLine("");
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Invalid input! Please enter 'y' or 'n'.");

                    }
                }
            }

        }
    }
}
