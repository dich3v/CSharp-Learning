﻿using System.Diagnostics.CodeAnalysis;

namespace Task_Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorCount = int.Parse(Console.ReadLine());
            int estateCount = int.Parse(Console.ReadLine());

            for (int i = floorCount; i > 0; i--)
            {
                for (int j = 0; j < estateCount; j++)
                {
                    if (i == floorCount)
                    {
                        Console.Write($"L{i}{j} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{j} ");
                    }
                    else
                    {
                        Console.Write($"A{i}{j} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
