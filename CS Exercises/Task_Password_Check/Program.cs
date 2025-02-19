using System.Collections.Generic;
using System.Threading.Channels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (password == input)
                {
                    Console.WriteLine($"Welcome {username}");
                    break;
                }
            }
        }
    }
}
