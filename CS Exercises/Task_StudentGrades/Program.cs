namespace Task_StudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int classCount = 1;
            int failedCount = 0;
            double totalGrades = 0;

            while (classCount <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                totalGrades += grade;
                if (grade < 4.00)
                {
                    failedCount++;
                    if (failedCount > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {classCount} grade");
                        return;
                    }
                }
                else
                {
                    classCount++;
                }
            }
            Console.WriteLine($"{name} graduated. Average grade: {totalGrades / 12:f2}");

        }
    }
}
