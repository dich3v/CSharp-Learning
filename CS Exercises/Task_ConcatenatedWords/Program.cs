using System.Text;

namespace Task_ConcatenatedWords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            string result = ConcatenateString(input).ToString();

            Console.WriteLine(result);
        }
        public static StringBuilder ConcatenateString(string[] input)
        {
            StringBuilder concantenatedString = new StringBuilder();

            foreach (string word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    concantenatedString.Append(word);
                }
            }
            return concantenatedString;
        }
    }
}
