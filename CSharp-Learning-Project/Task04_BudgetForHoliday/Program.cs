namespace Task04_BudgetForHoliday
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            string result = BudgetCalc(budget, nights, pricePerNight, percent);
            Console.WriteLine(result);
        }
        public static string BudgetCalc(double budget, int nights, double pricePerNight, double percent)
        {
            if (nights > 7)
            {
                pricePerNight *= 0.95;
            }
            double moneyNeeded = (nights * pricePerNight) + (budget * (percent / 100));

            if (moneyNeeded <= budget)
            {
                return $"Ivanovi will be left with {budget - moneyNeeded:f2} leva after vacation.";
            }
            else
            {
                return $"{moneyNeeded - budget:f2} leva needed.";
            }
        }
    }
}
