namespace Task_SumFactorialsOfEvenDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int factorialsSum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                if (digit % 2 == 0)
                {
                    int result = 1;

                    for (int i = 2; i <= digit; i++)
                    {
                        result *= i;
                    }
                    factorialsSum += result;
                }
                n /= 10;
            }
            Console.WriteLine(factorialsSum);
        }
    }
}
