using System.Text;

namespace Task_RepeatingText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = RepeatedText(input, n);

            Console.WriteLine(result);
        }
        static string RepeatedText(string text, int repeat)
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
