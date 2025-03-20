using System.Text;

namespace Task_TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                string replacedWord = "";
                for (int i = 0; i < word.Length; i++)
                {
                    replacedWord += "*";
                }
                text = text.Replace(word, replacedWord);
            }
            Console.WriteLine(text);
        }
    }
}
