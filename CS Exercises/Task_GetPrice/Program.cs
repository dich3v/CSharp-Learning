namespace Task_GetPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double result = GetPrice(product, quantity);

            Console.WriteLine($"{result:f2}");
        }
        static double GetPrice(string product, int quantity)
        {
            double price = product switch
            {
                "coffee" => 1.50,
                "water" => 1.00,
                "coke" => 1.40,
                "snacks" => 2.00,
                _ => 0
            };
            return quantity * price;
        }
    }
}
