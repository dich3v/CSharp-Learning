using System.Text;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > maxNum)
                {
                    maxNum = num;
                }
            }
            int finalSum = sum - maxNum;
            if (finalSum == maxNum)
            {
                Console.WriteLine($"Yes sum = {finalSum}");
            }
            else
            {
                Console.WriteLine($"No diff is {Math.Abs(finalSum-maxNum)}");
            }
        }
    }
}