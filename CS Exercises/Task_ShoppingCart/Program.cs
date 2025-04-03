namespace Task_ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();

            while (true)
            {
                try
                {
                    string command = Console.ReadLine().ToLower();

                    if (command == "checkout")
                    {
                        if (products.Count == 0)
                        {
                            Console.WriteLine("Your cart is empty. Add items before checking out.");
                            continue;
                        }
                        break;
                    }
                    if (command != "add" && command != "remove")
                    {
                        Console.WriteLine("Invalid command. Please enter 'add', 'remove', or 'checkout'.");
                        continue;
                    }
                    string name = Console.ReadLine();

                    if (command == "add")
                    {
                        int price = int.Parse(Console.ReadLine());

                        if (products.ContainsKey(name))
                        {
                            Console.WriteLine("Product with this name already exists. Try a different name.");
                        }
                        else
                        {
                            products.Add(name, price);
                            Console.WriteLine($"{name} added to cart.");
                        }
                    }
                    else if (command == "remove")
                    {
                        if (products.ContainsKey(name))
                        {
                            products.Remove(name);
                            Console.WriteLine($"{name} removed from cart.");
                        }
                        else
                        {
                            Console.WriteLine("Product does not exist in the cart.");
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for the price.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> ${product.Value}");
            }
        }
    }
}
