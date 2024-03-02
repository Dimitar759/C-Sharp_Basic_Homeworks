namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the fourth number:");
            int number4 = Convert.ToInt32(Console.ReadLine());


            int avgNumber = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine($"The average {number1}, {number2}, {number3} and {number4} is: {avgNumber}");
        }
    }
}
