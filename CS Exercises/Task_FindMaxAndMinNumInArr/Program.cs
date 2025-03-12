namespace Task_FindMaxAndMinNumInArr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > maxNum)
                {
                    maxNum = numbers[i];
                }
                if (numbers[i] < minNum)
                {
                    minNum = numbers[i];
                }
            }
            Console.WriteLine(maxNum);
            Console.WriteLine(minNum);
        }
    }
}
