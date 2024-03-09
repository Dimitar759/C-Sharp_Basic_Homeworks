namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hello from SEDC Codecademy 2024";
            Console.WriteLine("The sentence is: \n {0}", sentence);
            Console.WriteLine("");
            string result = Substrings(sentence);
            Console.WriteLine(result);
        }

        public static string Substrings(string randomSentence)
        {
            Console.WriteLine("Enter a random number:");
            int n = Convert.ToInt32(Console.ReadLine());

            char[] letters = randomSentence.ToCharArray();


            Console.WriteLine("");
            if (n >= 0 && n < letters.Length)
            {
                if (letters[n] == ' ')
                {
                    return "There's an empty space at that index.";
                }
                else
                {
                    string smallerRandomSentence = randomSentence.Substring(n);
                    string result = string.Format("The character at position {0} is \"{1}\" " +
                              "and the sentence starting from that index would be: " +
                              "\"{2}\" which is {3} characters long",
                              n, letters[n], smallerRandomSentence, smallerRandomSentence.Length);
                    return result;
                }
            }
            else
            {
                return $"Invalid input number. It should be within the range of the sentence length, which is {randomSentence.Length}";
            }


        }
    }
}
