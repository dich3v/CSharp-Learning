namespace Task_ProductSalesTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productsPrice = new Dictionary<string, double>();
            Dictionary<string, int> productsQuantity = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] products = input.Split(" ");
                string product = products[0];
                double price = double.Parse(products[1]);
                int quantity = int.Parse(products[2]);

                if (!productsQuantity.ContainsKey(product) && !productsPrice.ContainsKey(product))
                {
                    productsPrice[product] = price;
                    productsQuantity[product] = quantity;
                }
                else
                {
                    productsQuantity[product] += quantity;
                    productsPrice[product] = price;
                }
            }
            foreach (KeyValuePair<string, double> entry in productsPrice)
            {
                string productName = entry.Key;
                double totalPrice = entry.Value * productsQuantity[productName];
                Console.WriteLine($"{productName} -> {totalPrice:F2}");
            }
        }
    }
}
