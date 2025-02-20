namespace Task_Trip_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            double startMoney = double.Parse(Console.ReadLine());

            int daysCount = 0;
            int spendDays = 0;

            while (startMoney < tripPrice)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCount++;

                if (action == "spend")
                {
                    spendDays++;
                    startMoney -= money;
                    if (startMoney < 0)
                    {
                        startMoney = 0;
                    }
                    if (spendDays == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{daysCount}");
                        return;
                    }
                }
                else if (action == "save")
                {
                    startMoney += money;
                    spendDays = 0;
                }
            }
            Console.WriteLine($"You saved the money for {daysCount} days.");
        }
    }
}
