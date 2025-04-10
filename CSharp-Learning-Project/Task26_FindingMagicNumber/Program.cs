namespace Task26_FindingMagicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combinationCount = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combinationCount++;
                    if (magicNum == i + j)
                    {
                        Console.WriteLine($"Combination: {combinationCount}");
                        Console.WriteLine($"{i} + {j} = {magicNum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinationCount} combinations - neither equals {magicNum}");
        }
    }
}
