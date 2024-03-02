namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= number1; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Input another number:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            for (int i = number2; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
