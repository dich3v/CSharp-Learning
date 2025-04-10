namespace Task06_CakeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            CakeCalculator(length, width);
        }
        private static void CakeCalculator(int length, int width)
        {
            int size = length * width;

            while (size > 0)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{size} pieces are left.");
                    return;
                }
                size -= int.Parse(command);
            }
            Console.WriteLine($"No more cake left! You need {Math.Abs(size)} pieces more.");
        }
    }
}
