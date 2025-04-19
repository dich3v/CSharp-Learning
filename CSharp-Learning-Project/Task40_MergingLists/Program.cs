namespace Task40_MergingLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string result = MergeLists(firstList, secondList);
            Console.WriteLine(result);
        }

        public static string MergeLists(List<int> firstList, List<int> secondList)
        {
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
            return string.Join(" ", mergedList);
        }
    }
}
