namespace Task80_NumberProcessor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<double> result = NumberProcessor(list);

            Console.WriteLine(string.Join(" ", result));
        }
        public static List<double> NumberProcessor(List<int> numbers)
        {
            List<double> result = new List<double>();

            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    result.Add(number);
                }
                else if (number % 2 == 0)
                {
                    result.Add(Math.Pow(number, 2));
                }
                else
                {
                    result.Add(Math.Sqrt(number));
                }
            }
            return result;
        }
    }
}
