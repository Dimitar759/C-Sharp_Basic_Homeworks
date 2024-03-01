namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10; 
            int number2 = 15;
            int number3 = 20;
            int number4 = 30;


            int avgNumber = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine($"The average {number1}, {number2}, {number3} and {number4} is: {avgNumber}");
        }
    }
}
