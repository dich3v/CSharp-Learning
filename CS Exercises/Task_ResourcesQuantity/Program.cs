namespace Task_ResourcesQuantity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource = "";

            Dictionary<string, int> dict = new Dictionary<string, int>();

            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (dict.ContainsKey(resource))
                {
                    dict[resource] += quantity;
                }
                else
                {
                    dict.Add(resource, quantity);
                }
            }
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
