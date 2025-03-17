namespace Task_FindLargestElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> biggestNums = new List<int>();

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] <= list[j])
                    {
                        break;
                    }
                    if (j == list.Count - 1)
                    {
                        biggestNums.Add(list[i]);
                    }
                }
            }
            biggestNums.Add(list.Last());
            Console.WriteLine(string.Join(" ", biggestNums));
        }
    }
}
