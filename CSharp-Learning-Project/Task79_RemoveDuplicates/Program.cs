namespace Task79_RemoveDuplicates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] result = RemoveDuplicates(nums);

            Console.WriteLine(string.Join(" ", result));

        }
        public static int[] RemoveDuplicates(int[] numbers)
        {
            HashSet<int> uniqueNumbers = new();

            foreach (int number in numbers)
            {
                uniqueNumbers.Add(number);
            }

            return uniqueNumbers.ToArray();
        }
    }
}
