namespace Task45_PowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());

            int result = MathPow(number, pow);

            Console.WriteLine(result);
        }
        static int MathPow(int num, int power)
        {
            int result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
