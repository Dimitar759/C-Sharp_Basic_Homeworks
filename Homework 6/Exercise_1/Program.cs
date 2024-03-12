using System.Security.Cryptography;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string dogBreed;
            string dogName;
            string dogColor;
            while (true)
            {
                Console.WriteLine("Enter the dog's name:");
                dogName = Console.ReadLine();

                if (dogName == null || dogName.Trim() == "")
                {
                    Console.WriteLine("Please enter a valid name for the dog.");
                    continue;
                }

                Console.WriteLine("Enter the dog's breed:");
                dogBreed = Console.ReadLine();

                if (dogBreed == null || dogBreed.Trim() == "")
                {
                    Console.WriteLine("Please enter a valid breed for the dog.");
                    continue; 
                }

                Console.WriteLine("Enter the dog's color:");
                dogColor = Console.ReadLine();

                if (dogColor == null || dogColor.Trim() == "")
                {
                    Console.WriteLine("Please enter a valid color for the dog.");
                    continue; 
                }

                break;
            }

            Dog dog1 = new Dog()
            {
                Name = dogName,
                Breed = dogBreed,
                Color = dogColor

            };

            while (true)
            {
                Console.WriteLine("Choose one of the numbers: 1, 2, or 3");

                int number;
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue;
                }
                else if (number < 1 || number > 3)
                {
                    Console.WriteLine("Please enter a number between 1 and 3!");
                    continue;
                }
                else if(number == 1) 
                {
                    Console.WriteLine(dog1.Eat());
                }
                else if (number == 2)
                {
                    Console.WriteLine(dog1.Play());
                }else if (number == 3)
                {
                    Console.WriteLine(dog1.ChaseTail());
                }

                break;
            }
        }
    }
}
