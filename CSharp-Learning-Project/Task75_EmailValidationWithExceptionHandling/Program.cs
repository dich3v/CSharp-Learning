using System.Text.RegularExpressions;

namespace Task75_EmailValidationWithExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            Regex validEmail = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");

            try
            {
                if (string.IsNullOrWhiteSpace(email) || email.Contains(' '))
                {
                    throw new ArgumentException("Invalid email: Email cannot be empty or contain spaces");
                }
                if (email.StartsWith("@") || email.EndsWith("."))
                {
                    throw new FormatException("Invalid email: Cannot start with '@' or end with '.'");
                }
                if (!validEmail.IsMatch(email))
                {
                    throw new FormatException("Invalid email format.");
                }
                Console.WriteLine("Valid email");
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
