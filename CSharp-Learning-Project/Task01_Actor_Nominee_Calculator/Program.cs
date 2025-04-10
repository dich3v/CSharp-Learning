namespace Task01_Actor_Nominee_Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double startPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double finalPoints = startPoints;
            double pointsNeeded = 1250.5;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                finalPoints += (name.Length * points) / 2;
                if (finalPoints > pointsNeeded)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {finalPoints:f1}!");
                    return;
                }
            }
            Console.WriteLine($"Sorry, {actorName} you need {pointsNeeded - finalPoints:f1} more!");
        }
    }
}
