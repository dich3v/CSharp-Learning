namespace Task39_MergeConsecutiveEqualNumbers
{
    public class Program
    {
        public void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string result = MergeNumbers(numbers);
            Console.WriteLine(result);
        }
        public static string MergeNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            return string.Join(" ", numbers);
        }
    }
}
