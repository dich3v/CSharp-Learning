namespace Task12_CompanyEmployees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();

            while (command != "end")
            {
                string[] spltted = command.Split(" -> ");
                string companyName = spltted[0];
                string employeeID = spltted[1];

                if (!company.ContainsKey(companyName))
                {
                    company.Add(companyName, new List<string>());
                    company[companyName].Add(employeeID);
                }
                if (!company[companyName].Contains(employeeID))
                {
                    company[companyName].Add(employeeID);
                }
                command = Console.ReadLine();
            }
            foreach (var entry in company)
            {
                Console.WriteLine(entry.Key);
                foreach (var employee in entry.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
