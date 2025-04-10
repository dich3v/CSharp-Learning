namespace Task66_TextFilter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            string result = ReplaceBannedWords(text, bannedWords);
            Console.WriteLine(result);
        }
        public static string ReplaceBannedWords(string text, string[] bannedWords)
        {
            foreach (string word in bannedWords)
            {
                string replacedWord = new string('*', word.Length);
                text = text.Replace(word, replacedWord);
            }
            return text;
        }
    }
}