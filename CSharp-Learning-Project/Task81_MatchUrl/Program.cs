using System.Text.RegularExpressions;

namespace Task81_MatchUrl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = ExtractUrls(text);

            Console.WriteLine(result);
        }
        public static string ExtractUrls(string text)
        {
            string pattern = @"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&=]*)";
            Regex regex = new(pattern);

            MatchCollection matches = regex.Matches(text);

            List<string> urls = new();
            foreach (Match match in matches)
            {
                urls.Add(match.Value);
            }
            return string.Join(" ", urls);
        }
    }
}
