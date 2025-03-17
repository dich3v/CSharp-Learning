namespace Task_ZigZagLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int first = input[0];
                int second = input[1];

                if (i % 2 == 0)
                {
                    firstList.Add(first);
                    secondList.Add(second);
                }
                else
                {
                    firstList.Add(second);
                    secondList.Add(first);
                }
            }
            Console.WriteLine(string.Join(" ", firstList));
            Console.WriteLine(string.Join(" ", secondList));
        }
    }
}
