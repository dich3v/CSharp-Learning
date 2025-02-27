namespace Task_GetMultipleOfEvenAndOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOdds(num);

            Console.WriteLine(result);
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sumOfEven = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sumOfEven += digit;
                }
                number /= 10;
            }
            return sumOfEven;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sumOfOdd = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    sumOfOdd += digit;
                }
                number /= 10;
            }
            return sumOfOdd;
        }
        static int GetMultipleOfEvenAndOdds(int n)
        {
            int result = GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);
            return result;
        }
    }
}
