namespace Task_MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> mergedList = new List<int>();

            int iterations = firstList.Count >= secondList.Count ? firstList.Count : secondList.Count;

            for (int i = 0; i < iterations; i++)
            {
                if (i < firstList.Count)
                {
                    mergedList.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    mergedList.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", mergedList));
        }
    }
}
