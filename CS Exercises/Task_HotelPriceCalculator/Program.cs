namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string comment = Console.ReadLine();

            int nights = days - 1;
            double discount = 1;
            double finalPrice = 0;

            var prices = new Dictionary<string, double>()
            {
                { "room for one person", 18.00 },
                { "apartment", 25.00 },
                { "president apartment", 35.00 }
            };

            if(days < 10)
            {
                discount = room switch
                {
                    "apartment" => 0.7,
                    "president apartment" => 0.9,
                    _ => 1
                };
            }
            else if(days >= 10 && days <= 15)
            {
                discount = room switch
                {
                    "apartment" => 0.65,
                    "president apartment" => 0.85,
                    _ => 1
                };
            }
            else
            {
                discount = room switch
                {
                    "apartment" => 0.5,
                    "president apartment" => 0.8,
                    _ => 1
                };
            } 
            if(prices.ContainsKey(room))
            {
                finalPrice = nights * prices[room] * discount;
            }
           if(comment == "positive")
            {
                finalPrice *= 1.25; 
            } 
           else
            {
                finalPrice *= 0.9;
            }
            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}