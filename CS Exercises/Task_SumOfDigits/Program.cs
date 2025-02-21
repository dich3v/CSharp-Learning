namespace Task_SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                int sumOfDigits = 0;
                int digits = int.Parse(input);
                while (digits != 0)
                {
                    int lastDigit = digits % 10;
                    sumOfDigits += lastDigit;
                    digits /= 10;
                }
                Console.WriteLine($"Sum of digits = {sumOfDigits}");
                input = Console.ReadLine();
            }
            Console.WriteLine("Goodbye");
        }
    }
}
