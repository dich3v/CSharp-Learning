using System.Threading.Channels;

namespace Task_EvenOddsSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                string number = i.ToString();
                int evenSum = 0;
                int oddSum = 0;

                for (int j = 0; j < number.Length; j++)
                {
                    int digit = int.Parse(number[j].ToString());
                    if (j % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
