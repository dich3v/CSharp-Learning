using System.Text.RegularExpressions;

namespace Task81_ValidEmail
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string email = Console.ReadLine();
            bool result = IsValidEmail(email);

            Console.WriteLine(result);
        }
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new(pattern);

            return regex.IsMatch(email);
        }
    }
}
