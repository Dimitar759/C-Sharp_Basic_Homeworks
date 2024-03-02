using System.Linq.Expressions;

namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            double number1;
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("Invalid input, enter a number again:");
            }

            Console.WriteLine("Input another number:");
            double number2;
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("Invalid input, enter a number again:");
            }

            Console.WriteLine("Choose one of the following operations:  +, - , * , /");
            char operand;
            while (!char.TryParse(Console.ReadLine(), out operand))
            {
                Console.WriteLine("Invalid input, enter an operation again:");
            }


            double sum = 0;

            switch (operand)
            {
                case '+':
                    sum = number1 + number2;
                    Console.WriteLine(sum);
                    break;
                case '-':
                    sum = number1 - number2;
                    Console.WriteLine(sum);
                    break;
                case '*':
                    sum = number1 * number2;
                    Console.WriteLine(sum);
                    break;
                case '/':
                    sum = number1 / number2;
                    Console.WriteLine(sum);
                    break;
                default:
                    Console.WriteLine("Invalid operation selected");
                    break;
            }

        }
    }
}
