namespace Task70_VehicleRegistrationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> dict = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string command = input[0];
                string name = input[1];

                if (command == "register")
                {
                    string licensePlate = input[2];
                    if (dict.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {dict[name]}");
                    }
                    else
                    {
                        dict.Add(name, licensePlate);
                        Console.WriteLine($"{name} registered {licensePlate} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (!dict.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        dict.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                }
            }
            foreach (KeyValuePair<string, string> kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}