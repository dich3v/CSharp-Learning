namespace Task_Destinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double collectedMoney = 0;
                double neededBudget = double.Parse(Console.ReadLine());
                while (neededBudget > collectedMoney)
                {
                    collectedMoney += double.Parse(Console.ReadLine());
                    Console.WriteLine($"Collected: {collectedMoney:F2}");
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
