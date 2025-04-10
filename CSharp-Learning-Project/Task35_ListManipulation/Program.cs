namespace Task35_ListManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(" ");
                string act = input[0];

                switch (act)
                {
                    case "Add":
                        list.Add(int.Parse(input[1]));
                        break;

                    case "Remove":
                        list.Remove(int.Parse(input[1]));
                        break;

                    case "RemoveAt":
                        int index = int.Parse(input[1]);
                        if (index >= 0 && index < list.Count)
                        {
                            list.RemoveAt(index);
                        }
                        break;

                    case "Insert":
                        int insertIndex = int.Parse(input[2]);
                        if (insertIndex >= 0 && insertIndex <= list.Count)
                        {
                            list.Insert(insertIndex, int.Parse(input[1]));
                        }
                        break;

                    case "Contains":
                        Console.WriteLine(list.Contains(int.Parse(input[1])) ? "Yes" : "No such number");
                        break;

                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", list.Where(x => x % 2 == 0)));
                        break;

                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", list.Where(x => x % 2 != 0)));
                        break;

                    case "GetSum":
                        Console.WriteLine(list.Sum());
                        break;

                    case "Filter":
                        FilterNumbers(list, input);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
        private static void FilterNumbers(List<int> list, string[] input)
        {
            string condition = input[1];
            int number = int.Parse(input[2]);

            List<int> filteredList = new List<int>();

            switch (condition)
            {
                case "<":
                    filteredList = list.Where(x => x < number).ToList();
                    break;
                case "<=":
                    filteredList = list.Where(x => x <= number).ToList();
                    break;
                case ">":
                    filteredList = list.Where(x => x > number).ToList();
                    break;
                case ">=":
                    filteredList = list.Where(x => x >= number).ToList();
                    break;
            }
            Console.WriteLine(string.Join(" ", filteredList));
        }
    }
}
