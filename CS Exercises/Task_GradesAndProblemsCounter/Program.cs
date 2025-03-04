using static System.Reflection.Metadata.BlobBuilder;
using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int negativeGrades = int.Parse(Console.ReadLine());

            double grades = 0;
            int problemCount = 0;
            int poorGrades = 0;
            string lastName = "";

            string name = Console.ReadLine();
            while (name != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    poorGrades++;
                    if (poorGrades == negativeGrades)
                    {
                        Console.WriteLine($"You need a break, {poorGrades} poor grades.");
                        return;
                    }
                }
                problemCount++;
                grades += grade;
                lastName = name;
                name = Console.ReadLine();
            }
            Console.WriteLine($"Average score: {grades / problemCount}");
            Console.WriteLine($"Number of problems: {problemCount}");
            Console.WriteLine($"Last problem: {lastName}");
        }
    }
}
