namespace Task_Actor_Nominee_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double startPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double finalPoints = startPoints;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                finalPoints += (name.Length * points) / 2;
                if (finalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {finalPoints:f1}!");
                    return;
                }
            }
            Console.WriteLine($"Sorry, {actorName} you need {1250.5 - finalPoints:f1} more!");
        }
    }
}
