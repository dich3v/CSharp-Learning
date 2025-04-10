namespace Task64_SumOfPrimeAndNonPrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumOfPrimeNumbers = 0;
            int sumOfNonPrimeNumbers = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else if (number == 0 || number == 1)
                {
                    sumOfNonPrimeNumbers += number;
                }
                else
                {
                    bool isPrime = true;
                    for (int i = 2; i <= Math.Sqrt(number); i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        sumOfPrimeNumbers += number;
                    }
                    else
                    {
                        sumOfNonPrimeNumbers += number;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrimeNumbers}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrimeNumbers}");
        }
    }
}
