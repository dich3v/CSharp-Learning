namespace Task74_BasicUserAuthenticationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    break;
                }
                try
                {
                    if (input != "register" && input != "login")
                    {
                        Console.WriteLine("Please enter 'register' or 'login'");
                        continue;
                    }
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();

                    if (input == "register")
                    {
                        if (users.ContainsKey(username))
                        {
                            throw new ArgumentException("User with this name already exists.");
                        }

                        Console.Write("Enter password: ");
                        string password = Console.ReadLine();
                        users.Add(username, password);
                        Console.WriteLine("Your registration is successful!");
                    }
                    else if (input == "login")
                    {
                        if (!users.ContainsKey(username))
                        {
                            throw new KeyNotFoundException("User with this username does not exist.");
                        }

                        Console.Write("Enter password: ");
                        string password = Console.ReadLine();

                        if (users[username] == password)
                        {
                            Console.WriteLine("You have successfully logged in!");
                        }
                        else
                        {
                            throw new UnauthorizedAccessException("Incorrect password. Access denied.");
                        }
                    }
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message);
                }
                catch (ArgumentException aEx)
                {
                    Console.WriteLine(aEx.Message);
                }
                catch (KeyNotFoundException kEx)
                {
                    Console.WriteLine(kEx.Message);
                }
                catch (UnauthorizedAccessException uEx)
                {
                    Console.WriteLine(uEx.Message);
                }
            }
            Console.WriteLine("\nRegistered Users:");
            foreach (var user in users)
            {
                Console.WriteLine(user.Key);
            }
        }
    }
}
