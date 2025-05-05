using System.Text;

namespace Task82_CharacterCounter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            string result = Count(list);

            Console.WriteLine(result);
        }
        public static string Count(List<string> list)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (string item in list)
            {
                foreach (char c in item)
                {
                    if (!dict.ContainsKey(c))
                    {
                        dict[c] = 1;
                    }
                    else
                    {
                        dict[c]++;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<char, int> kvp in dict)
            {
                sb.AppendLine($"{kvp.Key} -> {kvp.Value}");
            }

            return sb.ToString();
        }
    }
}
