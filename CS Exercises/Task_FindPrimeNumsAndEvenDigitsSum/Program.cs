namespace Task_FindPrimeNumsAndEvenDigitsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool foundNumber = false;

            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int sum = 0;
                bool allDigitsPrime = true;

                while (num > 0)
                {
                    int digit = num % 10;
                    if (!isPrime(digit))
                    {
                        allDigitsPrime = false;
                        break;
                    }
                    sum += digit;
                    num /= 10;
                }
                if (allDigitsPrime && sum % 2 == 0)
                {
                    Console.Write($"{i} ");
                    foundNumber = true;
                }
            }
            if (!foundNumber)
            {
                Console.WriteLine("no");
            }
        }
        static bool isPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
