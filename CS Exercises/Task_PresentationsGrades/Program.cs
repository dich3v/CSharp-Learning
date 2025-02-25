namespace Task_PresentationsGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();

            double sumOfAllGrades = 0;
            int totalGradesCount = 0;

            while (presentationName != "Finish")
            {
                double grades = 0;
                for (int i = 0; i < juryCount; i++)
                {
                    grades += double.Parse(Console.ReadLine());
                    totalGradesCount++;
                }
                sumOfAllGrades += grades;
                Console.WriteLine($"{presentationName} - {grades / juryCount:f2}.");
                presentationName = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {sumOfAllGrades / totalGradesCount:f2}.");
        }
    }
}
