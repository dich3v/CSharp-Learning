namespace Task77_BankTransactionProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int finalSum = 0;

            while (command != "end")
            {
                int money = int.Parse(Console.ReadLine());

                try
                {
                    if (money < 0)
                    {
                        throw new ArgumentException("Negative deposit or withdrawal");
                    }
                    if (command == "deposit")
                    {
                        finalSum += money;
                    }
                    else if (command == "withdraw")
                    {
                        finalSum -= money;
                        if (finalSum < 0)
                        {
                            throw new Exception("Insufficient Funds");
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(finalSum);
        }
    }
}
