namespace Task_Clever_Lilly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toyCount = 0;
            int moneyCount = 0;
            int yearsCount = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyCount += i * 5;
                    yearsCount++;
                }
                else
                {
                    toyCount++;
                }
            }
            int savings = moneyCount - yearsCount;
            int savingFromToys = toyCount * toyPrice;
            int totalSavings = savings + savingFromToys;

            if (totalSavings - washPrice > 0)
            {
                Console.WriteLine($"Yes! {totalSavings - washPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washPrice - totalSavings:f2}");
            }
        }
    }
}
