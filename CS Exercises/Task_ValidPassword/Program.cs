namespace Task_ValidPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = true;

            if (!IsInRange(password))
            {
                isValid = false;
            }

            if (!IsDigitsAndLettersOnly(password))
            {
                isValid = false;
            }

            if (!IsContainingAtLeastTwoDigits(password))
            {
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsInRange(string input)
        {
            if (input.Length < 6 || input.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }
        static bool IsDigitsAndLettersOnly(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }
            }
            return true;
        }
        static bool IsContainingAtLeastTwoDigits(string input)
        {
            int count = 0;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    count++;
                }
            }
            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            return true;
        }
    }
}

