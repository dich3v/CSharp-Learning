namespace Task07_CalcAverageOfMiddleElementsInArr
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string result = FindSumOfMiddleIndexes(arr);
            Console.WriteLine(result);
        }
        public static string FindSumOfMiddleIndexes(int[] arr)
        {
            double middleSum = 0;

            if (arr.Length % 2 != 0)
            {
                int middleIndex = arr.Length / 2;
                middleSum = arr[middleIndex];
            }
            else
            {
                int middleIndex1 = (arr.Length / 2) - 1;
                int middleIndex2 = arr.Length / 2;

                middleSum = (arr[middleIndex1] + arr[middleIndex2]) / 2.0;
            }
            return $"{middleSum:F2}";
        }
    }
}
