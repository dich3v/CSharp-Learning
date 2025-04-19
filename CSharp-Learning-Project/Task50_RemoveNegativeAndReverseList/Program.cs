namespace Task50_RemoveNegativeAndReverseList
{
    public class Program
    {
        public void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string result = RemoveNegativeNumsAndReverse(list);

            Console.WriteLine(result);
        }
        public static string RemoveNegativeNumsAndReverse(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.Remove(list[i]);
                    i--;
                }
            }
            list.Reverse();
            if (list.Count > 0)
            {
                return string.Join(" ", list);
            }
            else
            {
                return "empty";
            }
        }
    }
}
