using System.Text;

namespace Task52_RepeatingText
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = RepeatedText(input, n);

            Console.WriteLine(result);
        }
        public static string RepeatedText(string text, int repeat)
        {
            StringBuilder repeatedText = new StringBuilder();
            for (int i = 0; i < repeat; i++)
            {
                repeatedText.Append(text);
            }
            return repeatedText.ToString();
        }
    }
}
