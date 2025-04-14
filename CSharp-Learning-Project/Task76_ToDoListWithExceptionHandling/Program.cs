namespace Task76_ToDoListWithExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> toDoList = new List<string>();

            while (true)
            {
                string input = Console.ReadLine().Trim();

                try
                {
                    if (string.IsNullOrWhiteSpace(input))
                    {
                        throw new FormatException("Command cannot be empty!");
                    }

                    string[] parts = input.Split(' ', 2);
                    string command = parts[0].ToLower();
                    string task = parts.Length > 1 ? parts[1].Trim() : "";

                    if (command == "exit")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    else if (command == "add")
                    {
                        if (string.IsNullOrEmpty(task))
                        {
                            throw new ArgumentException("Task description cannot be empty!");
                        }
                        if (toDoList.Contains(task))
                        {
                            throw new ArgumentException("Task already exists!");
                        }
                        toDoList.Add(task);
                        Console.WriteLine($"Task added: {task}");
                    }
                    else if (command == "remove")
                    {
                        if (string.IsNullOrEmpty(task))
                        {
                            throw new ArgumentException("Specify a task to remove!");
                        }
                        if (!toDoList.Contains(task))
                        {
                            throw new KeyNotFoundException("Task not found!");
                        }
                        toDoList.Remove(task);
                        Console.WriteLine($"Task removed: {task}");
                    }
                    else if (command == "view")
                    {
                        if (toDoList.Count == 0)
                        {
                            Console.WriteLine("No tasks available");
                        }
                        else
                        {
                            Console.WriteLine("Your To-Do List:");
                            for (int i = 1; i <= toDoList.Count; i++)
                            {
                                Console.WriteLine($"{i}. {toDoList[i - 1]}");
                            }
                        }
                    }
                    else
                    {
                        throw new FormatException("Invalid command! Use 'add', 'remove', 'view', or 'exit'.");
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (KeyNotFoundException kex)
                {
                    Console.WriteLine(kex.Message);
                }
            }
        }
    }
}
