namespace Task_Increasing_Amount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double finalSum = 0;

            while (input != "NoMoreMoney")
            {
                double sum = double.Parse(input);
                if (sum < 0)
                {
                    Console.WriteLine("Invalid Operation!");
                    break;
                }
                Console.WriteLine($"Increase: {sum:f2}");
                finalSum += sum;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {finalSum:F2}");
        }
    }
}
