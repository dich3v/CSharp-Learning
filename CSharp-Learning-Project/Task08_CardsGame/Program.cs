namespace Task08_CardsGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string result = CardGame(firstPlayer, secondPlayer);
            Console.WriteLine(result);
        }
        public static string CardGame(List<int> firstPlayer, List<int> secondPlayer)
        {
            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                int firstPlayerCard = firstPlayer[0];
                int secondPlayerCard = secondPlayer[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayer.Add(firstPlayerCard);
                    firstPlayer.Add(secondPlayerCard);
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    secondPlayer.Add(secondPlayerCard);
                    secondPlayer.Add(firstPlayerCard);
                }
                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
            }
            string winner = firstPlayer.Count > secondPlayer.Count ? "First" : "Second";
            int winnerSum = firstPlayer.Count > secondPlayer.Count ? firstPlayer.Sum() : secondPlayer.Sum();
            return $"{winner} player wins! Sum: {winnerSum}";
        }
    }
}
