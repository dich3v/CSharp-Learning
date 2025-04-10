using System;
using System.Collections.Generic;
using System.Text;

namespace Task17_DuplicatedCharactersCount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = GetCharacterCounts(input);
            Console.WriteLine(result);
        }

        public static string GetCharacterCounts(string text)
        {
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
            return sb.ToString();
        }
    }
}
