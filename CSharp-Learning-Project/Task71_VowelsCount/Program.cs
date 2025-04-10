namespace Task71_VowelsCount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = VowelsCount(input);

            Console.WriteLine(result);
        }
        public static string VowelsCount(string vowels)
        {
            int count = 0;

            string vowelsToLower = vowels.ToLower();

            for (int i = 0; i < vowelsToLower.Length; i++)
            {
                if (vowelsToLower[i] == 'a' || vowelsToLower[i] == 'e' || vowelsToLower[i] == 'o' || vowelsToLower[i] == 'u' || vowelsToLower[i] == 'i')
                {
                    count++;
                }
            }
            return count.ToString();
        }
    }
}