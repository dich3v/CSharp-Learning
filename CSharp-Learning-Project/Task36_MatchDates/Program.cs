using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex pattern = new Regex(@"(?<day>[0-9]{2})(?<separator>[./-])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})");

            MatchCollection matches = pattern.Matches(text);

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}