using System;

namespace Task28_GetMultipleOfEvenAndOdds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOdds(num);

            Console.WriteLine(result);
        }
        public static int GetSumOfEvenDigits(int number)
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
        public static int GetSumOfOddDigits(int number)
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
        public static int GetMultipleOfEvenAndOdds(int n)
        {
            int result = GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);
            return result;
        }
    }
}

