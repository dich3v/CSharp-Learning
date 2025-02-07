namespace CS_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            int springRent = 3000;
            int summerAutumn = 4200;
            int winterRent = 2600;
            double rent = 0;
            double discount = 0;

            if (fishermen <= 6)
            {
                discount = 0.9;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                discount = 0.85;
            }
            else if (fishermen >= 12)
            {
                discount = 0.75;
            }
            switch (season)
            {
                case "Summer":
                    rent = summerAutumn * discount; break;
                case "Autumn":
                    rent = summerAutumn * discount; break;
                case "Spring":
                    rent = springRent * discount; break;
                case "Winter":
                    rent = winterRent * discount; break;
                default: break;
            }
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                rent *= 0.95;
            }
            double finalSum = budget - rent;
            if (finalSum >= 0)
            {
                Console.WriteLine($"Yes! You have {finalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(finalSum):f2} leva.");
            }
        }
    }
}
