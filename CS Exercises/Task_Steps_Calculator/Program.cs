namespace Task_Steps_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalSteps = 0;
            int goal = 10000;

            while (finalSteps < goal)
            {
                string steps = Console.ReadLine();
                if (steps == "Going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    finalSteps += stepsToHome;
                    break;
                }
                finalSteps += int.Parse(steps);
            }
            if (finalSteps >= goal)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{finalSteps - goal} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{goal - finalSteps} more steps to reach goal.");
            }
        }
    }
}
