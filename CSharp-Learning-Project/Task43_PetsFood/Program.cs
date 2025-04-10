namespace Task43_PetsFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double allFood = double.Parse(Console.ReadLine());

            double biscuits = 0;
            double dogFoodEaten = 0;
            double catFoodEaten = 0;

            for (int i = 1; i <= days; i++)
            {
                double dogEat = double.Parse(Console.ReadLine());
                double catEat = double.Parse(Console.ReadLine());

                dogFoodEaten += dogEat;
                catFoodEaten += catEat;

                if (i % 3 == 0)
                {
                    biscuits += (dogEat + catEat) * 0.1;
                }
            }
            double eatenFood = dogFoodEaten + catFoodEaten;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(biscuits, 0)}gr.");
            Console.WriteLine($"{(eatenFood * 100) / allFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{(dogFoodEaten * 100) / eatenFood:f2}% eaten from the dog.");
            Console.WriteLine($"{(catFoodEaten * 100) / eatenFood:f2}% eaten from the cat.");
        }
    }
}
