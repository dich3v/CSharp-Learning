namespace Task_MaxValueComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = GetMax(input);
            Console.WriteLine(output);
        }
        static string GetMax(string type)
        {
            if (type == "string")
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();

                return text1.CompareTo(text2) > 0 ? text1 : text2;
            }
            else if (type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                return num1 > num2 ? num1.ToString() : num2.ToString();
            }
            else
            {
                char char1 = char.Parse(Console.ReadLine());
                char char2 = char.Parse(Console.ReadLine());

                return char1 > char2 ? char1.ToString() : char2.ToString();
            }
        }
    }
}
