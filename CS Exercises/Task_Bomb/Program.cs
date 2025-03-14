namespace Task_Bomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int[] bombNums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int bomb = bombNums[0];
            int bombPower = bombNums[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    int startIndex = i - bombPower;
                    int endIndex = i + bombPower;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= numbers.Count)
                    {
                        endIndex = numbers.Count - 1;
                    }
                    numbers.RemoveRange(startIndex, endIndex - startIndex + 1);
                    i = startIndex - 1;
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
