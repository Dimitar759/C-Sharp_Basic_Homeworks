using Modules2;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine("Please enter the following information about yourself:");
            Console.WriteLine("");

            while (true)
            {
                Console.Write("ID: ");
                string id = Console.ReadLine();

                if (!int.TryParse(id, out int idNumber))
                {
                    Console.WriteLine($"{id} isnt a valid id! Enter a valid id!");
                    continue;
                }
                else if (string.IsNullOrEmpty(id))
                {
                    Console.WriteLine("Enter a valid id!");
                    continue;
                }
                else if(int.TryParse(id, out int idNum))
                {
                    person.Id = idNum;
                    break;
                }
            }


            while (true)
            {
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                if (int.TryParse(firstName, out int fn))
                {
                    Console.WriteLine($"{fn} isnt a valid name! Enter a valid name!");
                    continue;
                }
                else if (string.IsNullOrEmpty(firstName)){
                    Console.WriteLine("Enter a valid name!");
                    continue;
                }
                else
                {
                    person.FirstName = firstName;
                    break;
                }
            }
            

            while (true)
            {
                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                if (int.TryParse(lastName, out int fn))
                {
                    Console.WriteLine($"{fn} isnt a valid name! Enter a valid name!");
                    continue;
                }
                else if (string.IsNullOrEmpty(lastName))
                {
                    Console.WriteLine("Enter a valid name!");
                    continue;
                }
                else
                {
                    person.LastName = lastName;
                    break;
                }
            }


            while (true)
            {

                Console.Write("Age: ");
                string age = Console.ReadLine();

                if (!int.TryParse(age, out int ageNum))
                {
                    Console.WriteLine($"{age} isnt a valid id! Enter a valid id!");
                    continue;
                }
                else if (string.IsNullOrEmpty(age))
                {
                    Console.WriteLine("Enter a valid id!");
                    continue;
                }
                else if (int.TryParse(age, out int ageNumb))
                {
                    person.Age = ageNumb;
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Favorite Music Type, enter between Classical, Hip Hop, Techno or Rock");
                string favouriteMusicType = Console.ReadLine().ToLower();

                if (favouriteMusicType.ToLower() == "classical")
                {
                    person.FavouriteMusicType = StatusEnum.Classical;
                    break;
                }
                else if (favouriteMusicType.ToLower() == "hip hop")
                {
                    person.FavouriteMusicType = StatusEnum.Hip_Hop;
                    break;

                }
                else if (favouriteMusicType.ToLower() == "techno")
                {
                    person.FavouriteMusicType = StatusEnum.Techno;
                    break;
                }
                else if (favouriteMusicType.ToLower() == "rock")
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
                Console.Write("Enter your favorite Song: ");
                string song = Console.ReadLine();

                if (string.IsNullOrEmpty(song))
                {
                    break; ;

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
