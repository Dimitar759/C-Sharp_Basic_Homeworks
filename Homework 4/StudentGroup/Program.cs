namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Matt", "Damian", "Silvester", "Stacey", "Mary" };
            string[] studentsG2 = { "Ben", "Kevin", "Qwen", "Max", "Ester" };

            Console.WriteLine("Enter the number 1 or the number 2");

            string input = Console.ReadLine();  

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please enter a number.");
                Console.WriteLine("");
                
            }
            else if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer (1 or 2).");
                Console.WriteLine("");
            }
            else if (input != "1" && input != "2")
            {
                Console.WriteLine("Invalid input. Please enter a valid integer (1 or 2).");
                Console.WriteLine("");
            }
            else
            {
                int groupNumber = int.Parse(input);

                if (groupNumber == 1)
                {
                    Console.WriteLine("The Students in G1 are:");
                    for (int i = 0; i < studentsG1.Length; i++) { Console.WriteLine(studentsG1[i]); }
                }

                if (groupNumber == 2)
                {
                    Console.WriteLine("The Students in G2 are:");
                    for (int i = 0; i < studentsG2.Length; i++) { Console.WriteLine(studentsG2[i]); }
                }
            }

        }
    }
}
