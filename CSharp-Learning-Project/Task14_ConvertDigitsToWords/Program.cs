namespace Task14_ConvertDigitsToWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                int digit = n % 10;
                string digitString = digit switch
                {
                    1 => "one",
                    2 => "two",
                    3 => "three",
                    4 => "four",
                    5 => "five",
                    6 => "six",
                    7 => "seven",
                    8 => "eight",
                    9 => "nine",
                    _ => "zero"
                };
                Console.WriteLine(digitString);
                n /= 10;
            }
        }
    }
}
