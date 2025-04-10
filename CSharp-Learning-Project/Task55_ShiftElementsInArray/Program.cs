namespace Task55_ShiftElementsInArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            int[] rotatedNumbers = RotateArray(numbers, n);

            Console.WriteLine(string.Join(" ", rotatedNumbers));
        }
        public static int[] RotateArray(int[] inputArray, int positions)
        {
            int[] resultArray = new int[inputArray.Length];
            int length = inputArray.Length;
            for (int i = 0; i < length; i++)
            {
                int newIndex = (i + positions) % length;
                resultArray[newIndex] = inputArray[i];
            }
            return resultArray;
        }
    }
}