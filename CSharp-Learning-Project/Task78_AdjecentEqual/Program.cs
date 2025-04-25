using System;
using System.Collections.Generic;

namespace Task78_AdjecentEqual
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string result = Sum(list);

            Console.WriteLine(result);
        }
        public static string Sum(List<int> numbers)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 0 || numbers[i] != numbers[i - 1])
                {
                    result.Add(numbers[i]);
                    continue;
                }
                result[result.Count - 1] += numbers[i];
            }

            return string.Join(" ", result);
        }
    }
}
