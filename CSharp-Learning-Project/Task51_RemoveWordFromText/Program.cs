using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Task51_RemoveWordFromText
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string word = Console.ReadLine();

            string result = RemoveWord(text, word);

            Console.WriteLine(result);
        }
        public static string RemoveWord(string text, string word)
        {
            int index = text.IndexOf(word, StringComparison.OrdinalIgnoreCase);
            while (index >= 0)
            {
                text = text.Remove(index, word.Length);
                index = text.IndexOf(word, StringComparison.OrdinalIgnoreCase);
            }
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            return text.Trim();
        }
    }
}
