using Modules;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine("Please enter the following information about yourself:");
            Console.Write("ID: ");
            person.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Age: ");
            person.Age = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                Console.Write("Favorite Music Type, enter between Classical, Hip Hop, Techno or Rock");
                string favouriteMusicType = Console.ReadLine().ToLower();

                if (favouriteMusicType.ToLower() == "Classical")
                {
                    person.FavouriteMusicType = StatusEnum.Classical;
                    break;
                }
                else if (favouriteMusicType.ToLower() == "Hip Hop")
                {
                    person.FavouriteMusicType = StatusEnum.Hip_Hop;
                    break;

                }
                else if (favouriteMusicType.ToLower() == "Techno")
                {
                    person.FavouriteMusicType = StatusEnum.Techno;
                    break;
                }
                else if (favouriteMusicType.ToLower() == "Rock")
                {
                    person.FavouriteMusicType = StatusEnum.Rock;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input, input some of the four genres: Classical, Hip Hop, Techno or Rock");
                    continue;
                }
            }


            Console.WriteLine("Enter your favorite songs (press Enter to stop):");
            person.FavouriteSongs = new List<string>();

            while (true)
            {
                Console.Write("Favorite Song: ");
                string song = Console.ReadLine();

                if (string.IsNullOrEmpty(song))
                {
                    break;

                }

                person.FavouriteSongs.Add(song);
            }

            Console.WriteLine("\nInformation entered:");
            Console.WriteLine($"ID: {person.Id}");
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Favorite Music Type: {person.FavouriteMusicType}");
            Console.WriteLine($"Favorite Songs: {person.GetFavSongs()}");
        }
    }
}
