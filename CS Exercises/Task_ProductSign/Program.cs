namespace Task_ProductSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            string result = PrintSign(num1, num2, num3);

            Console.WriteLine(result);
        }
        static string PrintSign(int num1, int num2, int num3)
        {
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                return "zero";
            }
            int negativeCount = 0;

            if (num1 < 0)
            {
                negativeCount++;
            }
            if (num2 < 0)
            {
                negativeCount++;
            }
            if (num3 < 0)
            {
                negativeCount++;
            }
            return (negativeCount % 2 == 1) ? "negative" : "positive";
        }
    }
}
