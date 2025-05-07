using System.Text;

namespace Task84_OddOccurrences
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split().ToArray();
            string result = FindOdd(strings);

            Console.WriteLine(result);
        }
        public static string FindOdd(string[] input)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (string word in input)
            {
                string lowercaseWord = word.ToLower();

                if (!wordCounts.ContainsKey(lowercaseWord))
                {
                    wordCounts[lowercaseWord] = 0;
                }

                wordCounts[lowercaseWord]++;
            }

            List<string> oddWords = new List<string>();

            foreach (KeyValuePair<string, int> kvp in wordCounts)
            {
                if (kvp.Value % 2 != 0)
                {
                    oddWords.Add(kvp.Key);
                }
            }
            return string.Join(" ", oddWords);
        }
    }
}
