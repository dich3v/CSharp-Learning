namespace Task_Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                    p1++;
                else if (num < 400)
                    p2++;
                else if (num < 600) 
                    p3++;
                else if (num < 800)
                    p4++;
                else
                    p5++;
            }

            double sum = 100 / n;
            double p1Percent = p1 * sum;
            double p2Percent = p2 * sum;
            double p3Percent = p3 * sum;
            double p4Percent = p4 * sum;
            double p5Percent = p5 * sum;

            Console.WriteLine($"{p1Percent:f2}%");
            Console.WriteLine($"{p2Percent:f2}%");
            Console.WriteLine($"{p3Percent:f2}%");
            Console.WriteLine($"{p4Percent:f2}%");
            Console.WriteLine($"{p5Percent:f2}%");
        }
    }
}
