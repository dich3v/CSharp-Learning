using System.Text;

namespace Task_ConcatenatedWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            StringBuilder concantenatedString = new StringBuilder();

            foreach (string word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    concantenatedString.Append(word);
                }
            }
            Console.WriteLine(concantenatedString);
        }
    }
}
