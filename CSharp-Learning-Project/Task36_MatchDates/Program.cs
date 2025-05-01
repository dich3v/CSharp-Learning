using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Task36_MatchDates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = Match(text);

            Console.WriteLine(result);
        }
        public static string Match(string dates)
        {
            if (string.IsNullOrWhiteSpace(dates))
            {
                throw new ArgumentException("Input cannot be null or empty!");
            }

            Regex pattern = new(@"\b(?<day>\d{2})(?<seperator>[-.\/])(?<month>[A-Z][a-z]+)\k<seperator>(?<year>\d{4})");

            MatchCollection matches = pattern.Matches(dates);
            List<string> results = new();

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                results.Add($"Day: {day}, Month: {month}, Year: {year}");
            }
            return results.Count > 0 ? string.Join("\n", results) : "No valid date found";
        }
    }
}