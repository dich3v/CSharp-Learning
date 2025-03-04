namespace Task_LetterCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            int count = 0;

            for (char firstChar = firstLetter; firstChar <= secondLetter; firstChar++)
            {
                for (char secondChar = firstLetter; secondChar <= secondLetter; secondChar++)
                {
                    for (char thirdChar = firstLetter; thirdChar <= secondLetter; thirdChar++)
                    {
                        if (firstChar != thirdLetter && secondChar != thirdLetter && thirdChar != thirdLetter)
                        {
                            Console.Write($"{firstChar}{secondChar}{thirdChar} ");
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine($"\n{count}");
        }
    }
}
