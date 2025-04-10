namespace Task65_SumOfValidIntegersWithErrorHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sum = ProcessInputAndCalculateSum(input);
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
        public static int ProcessInputAndCalculateSum(string[] input)
        {
            int sum = 0;

            foreach (string element in input)
            {
                try
                {
                    int number = int.Parse(element);
                    sum += number;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{element}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{element}' is out of range!");
                }
                Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
            }
            return sum;
        }
    }
}
