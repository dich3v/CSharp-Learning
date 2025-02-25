namespace Task_CinemaTicketingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie;

            int student = 0;
            int standard = 0;
            int kids = 0;
            double total = 0;

            while (true)
            {
                movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    break;
                }

                int seats = int.Parse(Console.ReadLine());
                double totalMovieTickets = 0;

                while (totalMovieTickets < seats)
                {
                    string ticket = Console.ReadLine();
                    if (ticket == "End")
                    {
                        break;
                    }
                    switch (ticket)
                    {
                        case "student":
                            student++;
                            break;
                        case "kid":
                            kids++;
                            break;
                        case "standard":
                            standard++;
                            break;
                    }
                    total++;
                    totalMovieTickets++;
                }
                Console.WriteLine($"{movie} - {totalMovieTickets * 100 / seats:F2}% full.");
            }
            Console.WriteLine($"Total tickets: {total}");
            Console.WriteLine($"{student * 100 / total:f2}% tickets");
            Console.WriteLine($"{standard * 100 / total:f2}% tickets");
            Console.WriteLine($"{kids * 100 / total:f2}% tickets");
        }
    }
}
