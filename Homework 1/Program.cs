namespace HomeworkOne{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  *");
            Console.WriteLine("  *");
            Console.WriteLine(" ***");
            Console.WriteLine("* * *");
            Console.WriteLine("  *");
            Console.WriteLine("  *");
            Console.WriteLine(" * *");
            Console.WriteLine("*   *");

            Console.WriteLine("Enter the man's name:");
            string name = Console.ReadLine();
            Console.WriteLine($"The man's name is {name}");
            Thread.Sleep(5000);

        }
    }
}
