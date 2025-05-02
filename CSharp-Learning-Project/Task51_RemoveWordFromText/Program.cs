namespace Task51_RemoveWordFromText
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine();

            string result = RemoveText(text, word);

            Console.WriteLine(result);
        }

        public static string RemoveText(string text, string word)
        {
            while (text.Contains(word))
            {
                int index = text.IndexOf(word);
                int count = word.Length;
                text = text.Remove(index, count);
            }
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            text = text.Trim();

            return text;
        }
    }
}
