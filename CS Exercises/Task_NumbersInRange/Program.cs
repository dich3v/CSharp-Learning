namespace Task_NumbersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = 1;
            int endNum = 100;

            ReadNumber(startNum, endNum);
        }
        public static void ReadNumber(int start, int end)
        {
            List<int> numbers = new();

            while (numbers.Count < 10)
            {
                try
                {
                    int num = int.Parse(Console.ReadLine());

                    if (num > start && num < end)
                    {
                        numbers.Add(num);
                        start = num;
                    }
                    else
                    {
                        throw new ArgumentException($"Your number is not in range {start} - 100!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
