namespace Task_FindingFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int result = FindFactorial(num1) / FindFactorial(num2);

            Console.WriteLine(result);
        }
        static int FindFactorial(int num)
        {
            int result = 1;

            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
