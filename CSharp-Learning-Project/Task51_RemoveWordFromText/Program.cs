namespace Task51_RemoveWordFromText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(word))
            {
                int index = text.IndexOf(word);
                int count = word.Length;
                text = text.Remove(index, count);
            }
            Console.WriteLine(text);
        }
    }
}
