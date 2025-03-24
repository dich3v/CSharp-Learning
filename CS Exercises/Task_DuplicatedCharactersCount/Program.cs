using System.Collections.Immutable;
using System.Globalization;
using System.Text;

namespace Task_DuplicatedCharactersCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = text.ToLower();

            HashSet<char> set = new HashSet<char>(text);

            StringBuilder sb = new StringBuilder();

            foreach (char c in set)
            {
                int count = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (c == text[i])
                    {
                        count++;
                    }
                }
                sb.Append(c);
                sb.Append(count);
            }
            Console.WriteLine(sb);
        }
    }
}
