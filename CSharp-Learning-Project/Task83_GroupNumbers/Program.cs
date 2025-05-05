using System;
using System.Text;

namespace Task83_GroupNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string result = GroupNumbers(list);

            Console.WriteLine(result);
        }
        public static string GroupNumbers(List<int> numbers)
        {
            HashSet<int> evens = new();
            HashSet<int> odds = new();
            HashSet<int> negatives = new();

            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    negatives.Add(number);
                }
                else if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Even numbers: {string.Join(", ", evens)}");
            sb.AppendLine($"Odd numbers: {string.Join(", ", odds)}");
            sb.AppendLine($"Negative numbers: {string.Join(", ", negatives)}");

            return sb.ToString().Trim();
        }
    }
}
