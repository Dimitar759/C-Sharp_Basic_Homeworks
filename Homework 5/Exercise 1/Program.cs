namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your birth year:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input your birth month (number):");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the day of your birth (number):");
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime birthDate = new DateTime(year, month, day);
            

            int age = CalculateAge(birthDate);

            Console.WriteLine($"Your age is: {age}");
        }

        public static int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthDate.Year;

           
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--; // Subtract one year if the birthday hasn't occurred yet this year
            }

            return age;
        }
    }
}
