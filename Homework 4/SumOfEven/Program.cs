namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = new int[6];

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {

                Console.WriteLine($"Enter the {(i + 1)}th number:");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a number.");
                    Console.WriteLine("");
                    continue;
                }
                else if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.WriteLine("");
                    continue;
                }
                else
                {
                    arrayOfNumbers[i] = number;
                }

            }

            int sum = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] % 2 == 0)
                {
                    sum += arrayOfNumbers[i];
                }
            }

            Console.WriteLine($"The sum of all even numbers is: {sum}");
        }
    }
}
