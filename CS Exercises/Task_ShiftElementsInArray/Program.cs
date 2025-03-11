using System;

namespace Task_ShiftElementsInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            int[] shiftedNumbers = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int newIndex = (i + n) % numbers.Length;
                shiftedNumbers[newIndex] = numbers[i];
            }
            Console.WriteLine(string.Join(" ", shiftedNumbers));
        }
    }
}
