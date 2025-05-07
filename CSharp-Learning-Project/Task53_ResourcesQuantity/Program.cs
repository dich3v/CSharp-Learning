using System.Text;

namespace Task53_ResourcesQuantity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            string result = Miner(list);
            Console.WriteLine(result);

        }
        public static string Miner(List<string> list)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            for (int i = 0; i < list.Count; i += 2)
            {
                string resource = list[i].ToLower();
                int quantity = int.Parse(list[i + 1]);

                if (dict.ContainsKey(resource))
                {
                    dict[resource] += quantity;
                }
                else
                {
                    dict.Add(resource, quantity);
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                sb.AppendLine($"{kvp.Key} -> {kvp.Value}");
            }
            return sb.ToString().Trim();
        }
    }
}
