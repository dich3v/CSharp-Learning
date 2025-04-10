namespace Task67_TradeCommissionCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                string town = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                double percent = 0;

                if (money >= 0 && money <= 500)
                {
                    percent = (town) switch
                    {
                        "Sofia" => 0.05,
                        "Varna" => 0.045,
                        "Plovdiv" => 0.055,
                        _ => -1
                    };
                }
                else if (money > 500 && money <= 1000)
                {
                    percent = (town) switch
                    {
                        "Sofia" => 0.07,
                        "Varna" => 0.075,
                        "Plovdiv" => 0.08,
                        _ => -1
                    };
                }
                else if (money > 1000 && money <= 10000)
                {
                    percent = (town) switch
                    {
                        "Sofia" => 0.08,
                        "Varna" => 0.1,
                        "Plovdiv" => 0.12,
                        _ => -1
                    };
                }
                else if (money > 10000)
                {
                    percent = (town) switch
                    {
                        "Sofia" => 0.12,
                        "Varna" => 0.13,
                        "Plovdiv" => 0.145,
                        _ => -1
                    };
                }
                if (percent == -1 || money < 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    Console.WriteLine($"{money * percent:F}");
                }

            }
        }
    }
}
