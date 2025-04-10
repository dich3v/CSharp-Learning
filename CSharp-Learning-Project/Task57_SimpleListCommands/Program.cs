namespace Task57_SimpleListCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(" ");

                if (input[0] == "Delete")
                {
                    while (numbers.Contains(int.Parse(input[1])))
                    {
                        numbers.Remove(int.Parse(input[1]));
                    }
                }
                else if (input[0] == "Insert")
                {
                    int value = int.Parse(input[1]);
                    int index = int.Parse(input[2]);

                    numbers.Insert(index, value);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
