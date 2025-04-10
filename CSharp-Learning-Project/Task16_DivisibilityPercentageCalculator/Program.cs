namespace Task16_DivisibilityPercentageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());

            int divideByTwo = 0;
            int divideByThree = 0;
            int divideByFour = 0;

            int count = 0;
            while (count < n)
            {
                double num = int.Parse(Console.ReadLine());

                divideByTwo += num % 2 == 0 ? 1 : 0;
                divideByThree += num % 3 == 0 ? 1 : 0;
                divideByFour += num % 4 == 0 ? 1 : 0;

                count++;
            }
            Console.WriteLine($"{(divideByTwo / n) * 100:f2}%");
            Console.WriteLine($"{(divideByThree / n) * 100:f2}%");
            Console.WriteLine($"{(divideByFour / n) * 100:f2}%");
        }
    }
}
