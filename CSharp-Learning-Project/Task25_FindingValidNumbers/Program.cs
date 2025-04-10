namespace Task25_FindingValidNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int num = i;
                bool isValid = true;

                while (num > 0)
                {
                    int digit = num % 10;
                    if (digit % 2 == 0)
                    {
                        isValid = false;
                        break;
                    }
                    num /= 10;
                }

                if (isValid)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
