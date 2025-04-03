namespace Task_Bomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int[] bombNums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            List<int> result = RemoveNumbers(numbers, bombNums);
            Console.WriteLine(result.Sum());
        }
        static List<int> RemoveNumbers(List<int> nums, int[] bombNumbers)
        {
            int bomb = bombNumbers[0];
            int bombPower = bombNumbers[1];

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == bomb)
                {
                    int startIndex = i - bombPower;
                    int endIndex = i + bombPower;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= nums.Count)
                    {
                        endIndex = nums.Count - 1;
                    }
                    nums.RemoveRange(startIndex, endIndex - startIndex + 1);
                    i = startIndex - 1;
                }
            }
            return nums;
        }
    }
}
